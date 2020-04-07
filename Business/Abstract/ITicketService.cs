using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITicketService
    {
        IDataResult<List<Ticket>> GetListByUserId(int userId);
        IResult Pay(Ticket ticket);
    }
}
