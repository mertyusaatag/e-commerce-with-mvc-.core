using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Business;
using ShopApp.Business.Abstract;
using ShopApp.Entites;
using ShopApp.Web.Identity;
using ShopApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Web.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private ICartService _cartService;
        private UserManager<ApplicationUser> _usermanager;
        private IOrderService _orderService;
        public CartController(ICartService cartService, UserManager<ApplicationUser> usermanager, IOrderService orderService)
        {
            _cartService = cartService;
            _usermanager = usermanager;
            _orderService = orderService;
        }
        public IActionResult Index()
        {
            var cart = _cartService.GetCartByUserId(_usermanager.GetUserId(User));


            return View(new CartModel()
            {
                CartId = cart.Id,
                CartItems = cart.CartItems.Select(i => new CartItemModel()
                {
                    CartItemId = i.Id,
                    Name = i.Product.Name,
                    ProductId = i.Product.Id,
                    Price = (decimal)i.Product.Price,
                    ImageUrl = i.Product.ImageUrl,
                    Quantity = i.Quantity
                }).ToList(),
            }
            );
        }
        [HttpGet]
        public IActionResult AddToCart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddToCart(int productId, int quantity)
        {
            _cartService.AddToCart(_usermanager.GetUserId(User), productId, quantity);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteFromCart(int productId)
        {
            _cartService.DeleteFromCart(_usermanager.GetUserId(User), productId);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Checkout()
        {
            var cart = _cartService.GetCartByUserId(_usermanager.GetUserId(User));

            var orderModel = new OrderModel();
            orderModel.CartModel= new CartModel()
            {
                CartId = cart.Id,
                CartItems = cart.CartItems.Select(i => new CartItemModel()
                {
                    CartItemId = i.Id,
                    Name = i.Product.Name,
                    ProductId = i.Product.Id,
                    Price = (decimal)i.Product.Price,
                    ImageUrl = i.Product.ImageUrl,
                    Quantity = i.Quantity
                }).ToList()

            };


            return View(orderModel);
        }

        [HttpPost]
        public IActionResult Checkout(OrderModel model)
        {
            if (ModelState.IsValid)
            {
                var userId = _usermanager.GetUserId(User);
                var cart = _cartService.GetCartByUserId(userId);

                model.CartModel = new CartModel()
                {
                    CartId = cart.Id,
                    CartItems = cart.CartItems.Select(i => new CartItemModel()
                    {
                        CartItemId = i.Id,
                        ProductId = i.Product.Id,
                        Name = i.Product.Name,
                        Price = (decimal)i.Product.Price,
                        ImageUrl = i.Product.ImageUrl,
                        Quantity = i.Quantity
                    }).ToList()
                };

                saveOrder(model, userId);
                ClearCart(cart.Id.ToString());
                return View("Success");
            }
            else
            {
                return View(model);
            }
            
        }

        private void ClearCart(string cartId)
        {
            _cartService.ClearCart(cartId);
        }

        private void saveOrder(OrderModel model, string userId)
        {
            var order = new Order();
            order.OrderNumber = new Random().Next(111111, 999999).ToString();
            order.orderState = EnumOrderState.Completed;
            order.OrderDate = new DateTime();
            order.FirstName = model.FirstName;
            order.LastName = model.LastName;
            order.Email = model.Email;
            order.Phone = model.Phone;
            order.Address = model.Address;
            order.UserId = userId;
            order.City = model.City;

            foreach (var item in model.CartModel.CartItems)
            {
                var orderitem = new OrderItem()
                {
                    Price=item.Price,
                    Quantity=item.Quantity,
                    ProductId=item.ProductId,
                   
                    
                };
                order.orderItems.Add(orderitem);
            }
            _orderService.Create(order);

        }
        [HttpGet]
        public IActionResult GetOrders()
        {
           var orders = _orderService.GetOrders(_usermanager.GetUserId(User));
            var orderListModel = new List<OrderListModel>();
            OrderListModel orderModel;

            foreach (var order in orders)
            {
                orderModel = new OrderListModel();
                orderModel.OrderId = order.Id;
                orderModel.OrderNumber = order.OrderNumber;
                orderModel.orderState = order.orderState;
                orderModel.FirstName = order.FirstName;
                orderModel.LastName = order.LastName;
                orderModel.Phone = order.Phone;
                orderModel.Address = order.Address;
                orderModel.OrderDate = order.OrderDate;
                orderModel.City = order.City;
                orderModel.Email = order.Email;

                orderModel.OrderItems = order.orderItems.Select(i => new OrderItemModel()
                {
                    OrderItemId = i.Id,
                    Name = i.Product.Name,
                    Price =i.Price,
                    Quantity=i.Quantity,
                    ImageUrl=i.Product.ImageUrl
                }).ToList();

                orderListModel.Add(orderModel);
            }

            return View(orderListModel);
        }
    }
}