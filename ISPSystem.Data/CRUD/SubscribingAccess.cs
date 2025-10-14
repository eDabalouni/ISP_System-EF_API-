using ISPSystem.Data.DTOs;
using ISPSystem.Domain.Models;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSystem.Data.CRUD
{
    public class SubscribingAccess
    {

        private ISPSystemContext _context = new ISPSystemContext();

        //Add Data
        public void AddSubscribe(Subscribing newSubscribe)
        {
            var subscribingDTO = newSubscribe.Adapt<SubscribingDTO>();
            _context.Subscribings.Add(newSubscribe);
            _context.SaveChanges();
        }

        //Read Data
        public Subscribing GetSubscribe(int id)
        {
            var subscribe = _context.Subscribings.FirstOrDefault(s => s.Id == id);
            return subscribe;
        }

        //Update Data
        public void UpdateSubscribe(Subscribing newSubscribe, int id)
        {
            var subscribe = _context.Subscribings.FirstOrDefault(s => s.Id == id);
            subscribe.DeliveredAt = newSubscribe.DeliveredAt;
            _context.SaveChanges();
        }


        //Delete Data
        public void DeleteSubscribe(int id)
        {
            var subscribe = _context.Subscribings.FirstOrDefault(s => s.Id == id);
            subscribe.IsDeleted = true; //soft delete

        }

    }
}
