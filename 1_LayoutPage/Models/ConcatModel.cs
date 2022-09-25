using System.ComponentModel.DataAnnotations;

namespace _1_LayoutPage.Models
{
	public class ContactModel
	{

		[Required(ErrorMessage ="Bu alan zorunludur")]
		public string Email { get; set; }


		[Required(ErrorMessage ="Mesaj alanı zorunludur")]
		public string Message { get; set; }
	}
}
