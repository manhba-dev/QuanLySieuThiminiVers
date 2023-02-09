using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinesssLayer
{
    public class SYS_SEQUENCE
    {
        Entities db;
        public SYS_SEQUENCE()
        {
            db = Entities.CreateEntities();
        }
        public tb_SYS_SEQUENCE getItem(string seqname)
        {
            return db.tb_SYS_SEQUENCE.FirstOrDefault(x => x.SEQNAME == seqname);
        }
        public  void add(tb_SYS_SEQUENCE sequence)
        {
            try
            {
                db.tb_SYS_SEQUENCE.Add(sequence);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi:" + ex.Message);
            }
        }
        public void update(tb_SYS_SEQUENCE sequence)
        {
            var seq = db.tb_SYS_SEQUENCE.FirstOrDefault(x => x.SEQNAME == sequence.SEQNAME);
            seq.SEQVALUE = sequence.SEQVALUE + 1;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi:" + ex.Message);
            }
        }
    }
}
