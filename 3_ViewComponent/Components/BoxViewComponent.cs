using Microsoft.AspNetCore.Mvc;

namespace _3_ViewComponent.Components
{

	// BoxViewComponent sınıfınımız view component gibi davranabilmesi için ViewComponent interfacesinden türemesi gerekir.


	// Kural;
	// 1) ViewComponent sınıf içerisinde Invoke isminde bir metot tanımlanmalıdır...

	public class BoxViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			List<string> ogrenciler = new List<string>();

			ogrenciler.Add("İsmail");
			ogrenciler.Add("Büşra");
			ogrenciler.Add("Onur");
			ogrenciler.Add("Ziya");

			return View(ogrenciler); // Views>Shared>Compoents>Box klasörü içerisinde ki default.cshtml isimli dosyayı döner.. yani her bir component için bu dosyası bu pathde oluşturmak gerekir...
		}
	}
}
