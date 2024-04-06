using System.ComponentModel.DataAnnotations;

namespace Validation.Models
{
	public class AddUser
	{
		public string IdentityNo { get; set; }


		[StringLength(20,MinimumLength =3,ErrorMessage ="Ad alanı belirlenen kurallar dahilinde değil")]
		[Required(ErrorMessage ="Ad alanı zorunlu alandır.")]
		public string Name { get; set; }


		[StringLength(60,MinimumLength =2,ErrorMessage ="Soy ad alanı belirlenen kurallar dahilinde değil")]
		[Required(ErrorMessage ="Soy Ad alanı zorunlu alandır.")]
		public string LastName { get; set; }

		[Required(ErrorMessage ="Email alanı boş bırakılamaz.")]
		[RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$",ErrorMessage ="Email uygun formatta değil, lütfen email giriniz")]
		public string Email { get; set; }

		[Required(ErrorMessage ="Yaş alanı zorunlu alandır.")]
		[Range(18,60,ErrorMessage ="Yaş belirlenen alanlar içerisinde olmalı")]
        public int Age { get; set; }


    }
}
