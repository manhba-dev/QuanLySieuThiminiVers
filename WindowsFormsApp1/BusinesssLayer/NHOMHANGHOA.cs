using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesssLayer
{
    public class NHOMHANGHOA
    {
        Entities db;
        public NHOMHANGHOA()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_NHOMHH> getList()
        {
            return db.tb_NHOMHH.ToList();
        }
        public tb_NHOMHH getItem(int ID)
        {
            return db.tb_NHOMHH.FirstOrDefault(x => x.IDNHOM == ID);
        }
        public void add(tb_NHOMHH xx)
        {
            try
            {
                db.tb_NHOMHH.Add(xx);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);
            }
        }
        public void update(tb_NHOMHH xx)
        {
            tb_NHOMHH _xx = db.tb_NHOMHH.FirstOrDefault(x => x.IDNHOM == xx.IDNHOM);
            _xx.TENNHOM = xx.TENNHOM;
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
            tb_NHOMHH _xx = db.tb_NHOMHH.FirstOrDefault(x => x.IDNHOM == ID);
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
