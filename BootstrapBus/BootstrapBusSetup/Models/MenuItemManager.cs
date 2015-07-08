using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootstrapBusSetup
{
    public class MenuItemManager
  {
        public MenuItemManager()    
    {
      Menus = new List<MenuItemOne>();
    }

        public List<MenuItemOne> Menus { get; set; }

    public void Load()
    {
        MenuItemOne entity = new MenuItemOne();

      entity.MenuId = 1;
      entity.MenuTitle = "Home";
      entity.DisplayOrder = 10;
      entity.MenuAction = "/Home/Home";
      Menus.Add(entity);

      entity = new MenuItemOne();
      entity.MenuId = 2;
      entity.MenuTitle = "Maintenance";
      entity.MenuAction = "/Maintenance/Maintenance";
      entity.DisplayOrder = 20;
      Menus.Add(entity);

      entity = new MenuItemOne();
      entity.MenuId = 3;
      entity.MenuTitle = "Reports";
      entity.MenuAction = "/Reports/Reports";
      entity.DisplayOrder = 30;
      Menus.Add(entity);

      entity = new MenuItemOne();
      entity.MenuId = 4;
      entity.MenuTitle = "Lookup";
      entity.MenuAction = "/Lookup/Lookup";
      entity.DisplayOrder = 30;
      Menus.Add(entity);
    }
  }
}