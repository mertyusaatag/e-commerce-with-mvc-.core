﻿using ShopApp.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.DataAccess.Abstract
{
    public interface ICartDal : IRepository<Cart>
    {
        Cart GetCartByUserId(string userId);
        void DeleteFromCart(int ıd, int productId);
        void ClearCart(string cartId);
    }
}
