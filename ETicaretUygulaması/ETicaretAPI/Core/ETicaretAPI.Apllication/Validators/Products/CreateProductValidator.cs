using ETicaretAPI.Apllication.ViewModels.Products;
using ETicaretAPI.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Apllication.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty().NotNull().WithMessage("Lütfen ürün adını boş geçmeyiniz.")
                .MaximumLength(100).MinimumLength(2).WithMessage("Lütfen 2 ile 100 karakter uzunluğunda bir isim giriniz.");
            RuleFor(p => p.Stock).NotEmpty().NotNull().WithMessage("Lütfen stok bilgisini boş geçmeyiniz.")
                .Must(s => s >= 0)
                .WithMessage("Lütfen sıfır veya sıfırdan yüksek bir değer giriniz");
            RuleFor(p => p.Price).NotEmpty().NotNull().WithMessage("Lütfen fiyat bilgisini boş geçmeyiniz.")
                .Must(s => s >= 0)
                .WithMessage("Lütfen sıfır veya sıfırdan yüksek bir değer giriniz");
        }
    }
}
