using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesssLayer
{
    public class XuatXu
    {
        Entities db;
        public XuatXu()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_XUATXU> getList()
        {
            return db.tb_XUATXU.ToList();
        }
        public tb_XUATXU getItem(int ID)
        {
            return db.tb_XUATXU.FirstOrDefault(x => x.ID == ID);
        }
        public void add(tb_XUATXU xx)
        {
            try
            {
                db.tb_XUATXU.Add(xx);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);
            }
        }
        public void update(tb_XUATXU xx)
        {
            tb_XUATXU _xx = db.tb_XUATXU.FirstOrDefault(x => x.ID == xx.ID);
            _xx.TEN = xx.TEN;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);
            }
        }
        public void delete(int ID)
        {
            tb_XUATXU _xx = db.tb_XUATXU.FirstOrDefault(x => x.ID == ID);
            _xx.DISABLED = true;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);
            }

        }
    }
}
