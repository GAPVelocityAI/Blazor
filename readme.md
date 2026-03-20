# Salmon King Seafood Reference App (SKS) — Blazor C#

# About the App

Salmon King Seafood (SKS) is a reference App created to show some of the migration capabilities of the Blazor conversion tool from [Growth Acceleration Partners](https://www.mobilize.net).

This repo contains the migrated SKS WinForms version, now running as a Blazor Server application (`SKS_Blazor_LiftedCode`).

# Building the App

If you want to build the migrated Blazor project on your development machine, check that you have the .NET 10 SDK installed.

Open `SKS_Blazor_LiftedCode\SKS_WinForms.sln` in Visual Studio (2022 or later).

When the solution is open, restore NuGet packages. The easiest way is to right-click the solution node and select `Manage NuGet Packages for Solution...`. The key packages are:

| Package | Version |
|--|--|
| `Gap.Blazor.All` | 2.35.87 |
| `Telerik.Licensing` | 1.6.31 |

Once all packages are restored, rebuild and run. The app starts as a Blazor Server app using Interactive Server rendering.

# Migrated Screens

Each WinForms form is converted to a `.cs` business logic file, a `.Designer.cs` control declaration file, and a `.razor` Razor component serving as the page.

| WinForms Form | Blazor View | Route |
|--|--|--|
| frmSplash | FrmSplashView.razor | /frmSplash |
| frmLogin | FrmLoginView.razor | /frmLogin |
| frmMain | FrmMainView.razor | /frmMain |
| frmAbout | FrmAboutView.razor | /frmAbout |
| frmCustomers | FrmCustomersView.razor | /frmCustomers |
| frmProducts | FrmProductsView.razor | /frmProducts |
| frmProviders | FrmProvidersView.razor | /frmProviders |
| frmSearch | FrmSearchView.razor | /frmSearch |
| frmUsersManage | FrmUsersManageView.razor | /frmUsersManage |
| frmOrderRequest | FrmOrderRequestView.razor | /frmOrderRequest |
| frmOrderReception | FrmOrderReceptionView.razor | /frmOrderReception |
| frmRequestAproval | FrmRequestApprovalView.razor | /frmRequestApproval |
| frmOrderAproval | FrmReceptionApprovalView.razor | /frmReceptionApproval |
| frmAddProductTo | FrmAddProductToView.razor | /frmAddProductTo |
| frmAddStockManual | FrmAddStockManualView.razor | /frmAddStockManual |
| frmAdjustStockManual | FrmAdjustStockManualView.razor | /frmAdjustStockManual |
| frmActionOrderRequest | FrmActionOrderRequestView.razor | /frmActionOrderRequest |
| frmActionOrderReception | FrmActionOrderReceptionView.razor | /frmActionOrderReception |

# Some Features of This Migration

## System.Windows.Forms Controls to Gap.Blazor Controls

All `System.Windows.Forms` control declarations in the `.Designer.cs` files are replaced with their `Gap.Blazor` equivalents. Properties become auto-properties instead of public fields.

| WinForms Class | Maps To |
|--|--|
| System.Windows.Forms.Form | Gap.Blazor.Form |
| System.Windows.Forms.TextBox | Gap.Blazor.TextBox |
| System.Windows.Forms.Button | Gap.Blazor.Button |
| System.Windows.Forms.Label | Gap.Blazor.Label |
| System.Windows.Forms.ComboBox | Gap.Blazor.ComboBox |
| System.Windows.Forms.CheckBox | Gap.Blazor.CheckBox |
| System.Windows.Forms.ListView | Gap.Blazor.ListView |
| System.Windows.Forms.PictureBox | Gap.Blazor.PictureBox |
| System.Windows.Forms.StatusStrip | Gap.Blazor.StatusStrip |
| System.Windows.Forms.ToolStrip | Gap.Blazor.ToolStrip |
| System.Windows.Forms.MenuStrip | Gap.Blazor.MenuStrip |
| System.Windows.Forms.Timer | Gap.Blazor.Timer |
| System.Windows.Forms.DateTimePicker | Gap.Blazor.DateTimePicker |
| System.Windows.Forms.GroupBox | Gap.Blazor.GroupBox |
| System.Windows.Forms.ToolTip | Gap.Blazor.ToolTip |
| UpgradeHelpers.DataGridViewFlex | Gap.Blazor.DataGridViewFlex |

**Before (frmLogin.Designer.cs — WinForms):**

```csharp
// WinForms: public fields, System.Windows.Forms types
public System.Windows.Forms.TextBox txtUserName;
public System.Windows.Forms.Button cmdCancel;
public System.Windows.Forms.TextBox txtPassword;
public System.Windows.Forms.Button cmdOK;
private System.ComponentModel.IContainer components;
public System.Windows.Forms.ToolTip ToolTipMain;
```

**After (frmLogin.Designer.cs — Blazor):**

```csharp
// Blazor: auto-properties, Gap.Blazor types
public Gap.Blazor.TextBox txtUserName { get; set; }
public Gap.Blazor.Button cmdCancel { get; set; }
public Gap.Blazor.TextBox txtPassword { get; set; }
public Gap.Blazor.Button cmdOK { get; set; }
private Gap.Blazor.IContainer components;
public Gap.Blazor.ToolTip ToolTipMain { get; set; }
```

## DataGridViewFlex to Gap.Blazor.DataGridViewFlex

Maps `UpgradeHelpers.DataGridViewFlex` to the `Gap.Blazor.DataGridViewFlex` implementation.

| Class | Maps To |
|--|--|
| UpgradeHelpers.DataGridViewFlex | Gap.Blazor.DataGridViewFlex |

**Before:**

```csharp
public UpgradeHelpers.DataGridViewFlex fgProducts;
```

**After:**

```csharp
public Gap.Blazor.DataGridViewFlex fgProducts { get; set; }
```

## Static State: Static Fields to StaticService

WinForms forms used static C# fields to hold the singleton instance and initialization flag. In the Blazor version these are replaced with `StaticService.Get/Set` calls to ensure proper per-session scoping in a web environment.

**Before (WinForms):**

```csharp
private static frmLogin m_vb6FormDefInstance;
private static bool m_InitializingDefInstance;
```

**After (Blazor):**

```csharp
private static frmLogin m_vb6FormDefInstance
{
    get => StaticService.Get<frmLogin>($"{typeof(frmLogin).FullName}.m_vb6FormDefInstance");
    set => StaticService.Set($"{typeof(frmLogin).FullName}.m_vb6FormDefInstance", value);
}

private static bool m_InitializingDefInstance
{
    get => StaticService.Get<bool>($"{typeof(frmLogin).FullName}.m_InitializingDefInstance");
    set => StaticService.Set($"{typeof(frmLogin).FullName}.m_InitializingDefInstance", value);
}
```

## Program Startup: WinForms Application to Blazor Server Host

The entry point changes from a WinForms `Application.Run` call to a full ASP.NET Core Blazor Server host with dependency injection, session management, and Telerik UI registration.

**Before (modMain.cs — WinForms):**

```csharp
[STAThread]
public static void Main()
{
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    ConnectionString = "DRIVER=SQLite3 ODBC Driver; Database=Orders.db; ...";
    modConnection.OpenConnection();
    Application.Run(frmMain.DefInstance);
}
```

**After (Program.cs — Blazor):**

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTelerikBlazor();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped<Gap.Blazor.Application>();
builder.Services.AddDynamicControlServices();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(1);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();
app.UseAntiforgery();
app.UseSession();
app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();
app.Run();
```

## UI Library: Telerik UI for Blazor

The migrated app uses [Telerik UI for Blazor](https://www.telerik.com/blazor-ui) as the underlying Razor component library. The root layout wraps all content in `<TelerikRootComponent>` and the Kendo Default theme is applied.

```razor
@* Components/Layout/MainLayout.razor *@
@inherits LayoutComponentBase

<TelerikRootComponent>
    @Body
</TelerikRootComponent>
```

# Manual Changes Required — Double-Jump Migration

This project is the result of a **double-jump migration**: the original application was written in **Visual Basic 6 (VB6)**, which was first migrated to **C# WinForms** and then converted again to **Blazor**. Because the C# WinForms intermediate step already carries patterns and artifacts inherited from VB6 (such as legacy ADO data controls, VB6-style helper libraries, and COM interop references), the automated Blazor conversion alone is not sufficient to produce a fully working web application.

Some constructs that existed in VB6 and survived into the C# WinForms layer do not have a direct automated mapping to Blazor and require manual intervention to work correctly in a browser context.

The folder **`SKS_Blazor_ManuallyChangedCode`** contains the files from `SKS_Blazor_LiftedCode` that required manual edits after the automated conversion, for more information about the changes refer to the [SKS Blazor summary](SKS_Blazor_Changes_Summary.md). Use it as a reference for the kinds of changes typically needed:

- Adjustments to data-access logic that relied on VB6-style ADO patterns.
- Replacement or removal of COM interop and legacy `UpgradeHelpers` constructs that have no Blazor equivalent.
- Fixes to form lifecycle logic (e.g., `Form_Load` equivalents) to align with the Blazor component lifecycle (`OnInitializedAsync`, `OnAfterRenderAsync`).
- UI corrections where VB6-originated layout assumptions needed manual Razor markup adjustments.

When comparing `SKS_Blazor_LiftedCode` (automated output) against `SKS_Blazor_ManuallyChangedCode` (manually corrected version), the differences highlight the residual work a developer should expect after running the automated conversion tool on a double-jump codebase.