using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class RoomBLL
    {
        ManagePatientDataContext db;
        public RoomBLL()
        {
            db = new ManagePatientDataContext();
        }

        public IEnumerable<RoomInfo> GetAllRoom()
        {
            IEnumerable<RoomInfo> data = db.RoomInfos;
            return data;
        }

        public Dictionary<string,string> GetAllRoomDic()
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            foreach ( var item in db.RoomInfos)
            {
                data.Add(item.IDRoom, item.NameRoom);
            }
            return data;
        }

        public List<string> GetAllNameRoom()
        {
            List<string> data = new List<string>();
            foreach(var item in db.RoomInfos)
            {
                data.Add(item.NameRoom);
            }
            return data;
        }

        public void Add1Room(RoomInfo room)
        {
            db.RoomInfos.InsertOnSubmit(room);
            db.SubmitChanges();
        }

        public void Del1Room(RoomInfo room)
        {
            RoomInfo delroom = (from ro in db.RoomInfos
                                where ro.IDRoom == room.IDRoom
                                select ro).FirstOrDefault();
            db.RoomInfos.DeleteOnSubmit(delroom);
            db.SubmitChanges();
        }

        public void ChangeInfo(RoomInfo room)
        {
            RoomInfo updateroom = (from ro in db.RoomInfos
                                   where ro.IDRoom == room.IDRoom
                                   select ro).FirstOrDefault();
            updateroom.IDRoom = room.IDRoom;
            updateroom.NameRoom = room.NameRoom;
            updateroom.CommentRoom = room.CommentRoom;
            db.SubmitChanges();
        }

        public void Update()
        {
            db.SubmitChanges();
        }
    }
}
