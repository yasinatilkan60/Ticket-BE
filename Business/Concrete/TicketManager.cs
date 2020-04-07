using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class TicketManager : ITicketService
    {
        private ITicketDal _ticketDal;
        public TicketManager(ITicketDal ticketDal)
        {
            _ticketDal = ticketDal;
        }
        public IDataResult<List<Ticket>> GetListByUserId(int userId)
        {
            return new SuccessDataResult<List<Ticket>>(_ticketDal.GetList(t => t.UserId == userId).ToList());
        }

        public IResult Pay(Ticket ticket)
        {
            _ticketDal.Add(ticket);
            return new SuccessResult(Messages.TicketPaid);
        }
    }
}
