using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesssLayer
{
    public class DONVITINH
    {
        Entities db;
        public DONVITINH()
        {
            db = Entities.CreateEntities();
        }
        public List<tb_DVT> getList()
        {
            return db.tb_DVT.ToList();
        }
        public tb_DVT getItem(int ID)
        {
            return db.tb_DVT.FirstOrDefault(x => x.ID == ID);
        }
        public void add(tb_DVT dvt)
        {
            try
            {
                db.tb_DVT.Add(dvt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lí dữ liệu." + ex.Message);
            }
        }
        public void update(tb_DVT dvt)
        {
            tb_DVT _dvt = db.tb_DVT.FirstOrDefault(x => x.ID == dvt.ID);
            _dvt.TEN = dvt.TEN;
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
