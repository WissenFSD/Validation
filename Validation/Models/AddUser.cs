using System.ComponentModel.DataAnnotations;

namespace Validation.Models
{
	public class AddUser
	{
		[Required(ErrorMessage ="Tc Kimlik No boş olamaz")]
		[Display(Name = "Tc Kimlik No")]
		[StringLength(11,ErrorMessage ="Tc kimlik numarası 11 karakter olmalıdır.")]
		[RegularExpression("^[1-9]{1}[0-9]{9}[02468]{1}$",ErrorMessage ="Girilen kimlik numarası uygun formatta değil")]
		public string IdentityNo { get; set; }

		[Display(Name="İsim")]
		[StringLength(20,MinimumLength =3,ErrorMessage ="Ad alanı belirlenen kurallar dahilinde değil")]
		[Required(ErrorMessage ="Ad alanı zorunlu alandır.")]
		public string Name { get; set; }

		[Display(Name = "Soyisim")]
		[StringLength(60,MinimumLength =2,ErrorMessage ="Soy ad alanı belirlenen kurallar dahilinde değil")]
		[Required(ErrorMessage ="Soy Ad alanı zorunlu alandır.")]
		public string LastName { get; set; }

		[Display(Name = "E-Posta")]
		[Required(ErrorMessage ="Email alanı boş bırakılamaz.")]
		[RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$",ErrorMessage ="Email uygun formatta değil, lütfen email giriniz")]
		public string Email { get; set; }

		[Display(Name = "Yaş")]
		[Required(ErrorMessage ="Yaş alanı zorunlu alandır.")]
		[Range(18,60,ErrorMessage ="Yaş belirlenen alanlar içerisinde olmalı")]
        public int Age { get; set; }


    }
}
