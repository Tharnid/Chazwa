using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NavbarDataDriven
{
    public class MenuItemManager1
 {
    public MenuItemManager1()    
    {
      Menus = new List<MenuItem1>();
    }

    public List<MenuItem1> Menus { get; set; }

    public void Load()
    {
        MenuItem1 entity = new MenuItem1();

      entity.MenuId = 1;
      entity.MenuTitle = "Home";
      entity.DisplayOrder = 10;
      entity.MenuAction = "/Home/Home";
      Menus.Add(entity);

      entity = new MenuItem1();
      entity.MenuId = 2;
      entity.MenuTitle = "Maintenance";
      entity.MenuAction = "/Maintenance/Maintenance";
      entity.DisplayOrder = 20;
      Menus.Add(entity);

      entity = new MenuItem1();
      entity.MenuId = 3;
      entity.MenuTitle = "Reports";
      entity.MenuAction = "/Reports/Reports";
      entity.DisplayOrder = 30;
      Menus.Add(entity);

      entity = new MenuItem1();
      entity.MenuId = 4;
      entity.MenuTitle = "Lookup";
      entity.MenuAction = "/Lookup/Lookup";
      entity.DisplayOrder = 30;
      Menus.Add(entity);
    }
  }
}