using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


namespace BusinesssLayer
{
    public class HANGHOA
    {
        Entities db;


        public HANGHOA()
        {
            db = Entities.CreateEntities();
        }
        public tb_HANGHOA getItem(string barcode)
        {
            return db.tb_HANGHOA.FirstOrDefault(x => x.BARCODE == barcode);
        }
        public List<tb_HANGHOA> getListByNhom (int idnhom)
        {
            return db.tb_HANGHOA.Where(x => x.IDNHOM == idnhom).OrderBy(o => o.CREATED_DATE).ToList();
        }
        public List<tb_HANGHOA> getlist()
        {
            return db.tb_HANGHOA.ToList();
        }
        public tb_HANGHOA add(tb_HANGHOA hh)
        {
            try
            {
                db.tb_HANGHOA.Add(hh);
                db.SaveChanges();
                return hh;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_HANGHOA update(tb_HANGHOA hh)
        {

            tb_HANGHOA _hh = db.tb_HANGHOA.FirstOrDefault(x => x.BARCODE == hh.BARCODE);
            _hh.TENHH = hh.TENHH;
            _hh.TENTAT = hh.TENTAT;
            _hh.DVT = hh.DVT;
            _hh.DONGIA = hh.DONGIA;
            _hh.IDNHOM = hh.IDNHOM;
            _hh.MOTA = hh.MOTA;
            _hh.MANCC = hh.MANCC;
            _hh.MAXX = hh.MAXX;
            _hh.DISABLED = hh.DISABLED;
            try
            {
                
                db.SaveChanges();
                return _hh;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void delete(string barcode)
        {

            tb_HANGHOA _hh = db.tb_HANGHOA.FirstOrDefault(x => x.BARCODE ==barcode);
            _hh.DISABLED = true;
            try
            { 
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
