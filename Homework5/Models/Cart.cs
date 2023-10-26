using System.ComponentModel.DataAnnotations;

namespace Homework5.Models
{
    public class Cart
    {
        public int Id { get; set; }

        [Display(Name = "商品序号")]
        [Required(ErrorMessage = "商品序号不可为空！")]
        public int ProductId { get; set; }

        [Display(Name = "用户ID")]
        [Required(ErrorMessage = "用户ID不可为空！")]
        public int UserId { get; set; }

        [Display(Name = "商品单价")]
        [Required(ErrorMessage = "商品单价不可为空！")]
        public decimal Price { get; set; }

        [Display(Name = "加购数量")]
        [Range(1, 100000, ErrorMessage = "加购数量不合理!")]
        [Required(ErrorMessage = "加入购物车数量必填")]
        public int ProductNum { get; set; }

        [Display(Name = "加购时间")]
        [Required(ErrorMessage = "时间必填！")]
        [DataType(DataType.Date)]
        public DateTime CreateTime { get; set; }
    }
}
