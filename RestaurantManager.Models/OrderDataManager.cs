﻿using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class OrderDataManager : DataManager
    {
        private List<MenuItem> _menuItems;
        private List<MenuItem> _currentlySelectedMenuItems;
        
        protected override void OnDataLoaded()
        {
            this.MenuItems = base.Repository.StandardMenuItems;

            this.CurrentlySelectedMenuItems = new List<MenuItem>
            {
                this.MenuItems[3],
                this.MenuItems[5]
            };
        }

        public List<MenuItem> MenuItems
        {
            get { return _menuItems; }
            set
            {
                _menuItems = value;
            }
        }

        public List<MenuItem> CurrentlySelectedMenuItems
        {
            get { return _currentlySelectedMenuItems; }
            set
            {
                _currentlySelectedMenuItems = value;
            }
        }
    }
}
