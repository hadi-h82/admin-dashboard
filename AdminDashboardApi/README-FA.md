# AdminDashboardApi

این پروژه بر اساس معماری لایه‌ای (Layered Architecture) و با رعایت اصول Clean Architecture ساخته شده است.

## 📁 ساختار پروژه

AdminDashboardApi
│
├── Application           # لایه‌ای که قوانین کسب‌وکار (Business Logic) را پیاده‌سازی می‌کند.
│   ├── Interfaces        # اینجا اینترفیس‌ها قرار می‌گیرند.
│   └── Services          # اینجا کلاس‌های مربوط به منطق‌های کسب‌وکار قرار می‌گیرند.
│
├── Domain                # این لایه مربوط به Entities و مدل‌ها (مثل User، Role) می‌باشد.
│   ├── Entities          # مدل‌های داده (مثل User، Role، Permission)
│   └── Enums             # انواع و مقادیر پیش‌فرض مثل RoleType
│
├── Infrastructure        # لایه‌ای که وابستگی‌های خارجی (مثل دیتابیس، فایل‌سیستم، APIها) را مدیریت می‌کند.
│   ├── Data              # کلاس‌های مربوط به دیتابیس و کانفیگ‌ها
│   ├── Repositories      # کلاس‌های مربوط به دسترسی به دیتا
│   └── Services          # خدمات وابسته به دیتابیس یا سایر سیستم‌ها
│
├── Presentation          # لایه مربوط به APIها و User Interface می‌باشد.
│   ├── Controllers       # کنترلرهای API
│   └── Models            # مدل‌های مربوط به درخواست‌ها و پاسخ‌ها (مثل Dtoها)
│
└── Shared                # لایه مشترک برای چیزهایی که در همه‌جا استفاده می‌شود (مثل Helpers و Exceptions)


---

## 🛠️ تکنولوژی‌های استفاده شده

- ASP.NET Core 9.0
- Clean Architecture Principles
- JWT Authentication/Authorization (در فازهای بعدی)
- Entity Framework Core (آتی برای مدیریت دیتابیس)

---

## 🚀 نحوه اجرا (Run کردن پروژه)

1. وارد پوشه‌ی `AdminDashboardApi` شوید.
2. دستورات زیر را اجرا کنید:

```bash
dotnet restore
dotnet build
dotnet run
