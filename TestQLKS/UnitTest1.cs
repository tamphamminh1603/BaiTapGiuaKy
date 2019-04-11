﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLKS;

namespace TestQLKS
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDangNhapThanhCong()
        {
            string user = "admin";
            string pass = "123";
            user u = new Users();
            bool condition = u.Login(user, pass);

            Assert.IsTrue(condition);
        }

        [TestMethod]
        public void TestLoginKhongNhapPass()
        {
            string user = "admin";
            string pass = "";
            Users u = new Users();
            bool condition = u.Login(user, pass);

            Assert.IsFalse(condition);
        }
        [TestMethod]
        public void TestLoginKhongNhapUser()
        {
            string user = "";
            string pass = "123";
            Users u = new Users();
            bool condition = u.Login(user, pass);

            Assert.IsFalse(condition);
        }
}
