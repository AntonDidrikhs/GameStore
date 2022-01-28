using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameStore.Models
{
    public class ClientTransaction
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string? DeliveryAdress { get; set; }
        public decimal Payment { get; set; }
    }
}
