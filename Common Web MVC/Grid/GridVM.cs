using System.Collections.Generic;

namespace Ferdo.Common.Web.MVC.Grid
{
    public class GridVm<T>
    {
        public GridVm()
        {
            GridList = new List<GridModel<T>>();
        }
        public List<GridModel<T>> GridList { get; set; }
    }
}