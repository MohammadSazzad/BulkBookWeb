# BulkBookWeb 📚

A comprehensive ASP.NET Core MVC web application built from the ground up, showcasing modern web development practices with clean architecture principles. This project implements a complete book management system with category management, product management, and advanced UI features.

## 🏗️ Project Architecture

The solution follows a clean, layered architecture pattern with clear separation of concerns:

```
BulkBookWeb/
├── BulkProject/           # Main Web Application (Presentation Layer)
│   ├── Areas/
│   │   ├── Admin/         # Administrative functionality
│   │   └── Customer/      # Customer-facing functionality
│   ├── Views/            # Razor views and layouts
│   └── wwwroot/          # Static files (CSS, JS, images)
├── Bulk.Models/           # Data Models & Entities
│   ├── ViewModels/       # View models for complex scenarios
│   └── Product.cs, Category.cs
├── Bulk.DataAccess/       # Data Access Layer with Repository Pattern
│   ├── Repository/       # Repository implementations
│   └── Data/            # DbContext and migrations
├── Bulk.Utility/          # Shared Utilities & Helpers
└── BulkProject.sln        # Solution File
```

## ✨ Features

### 📂 Category Management
- **Complete CRUD Operations**: Create, read, update, and delete categories
- **Server-side Validation**: Comprehensive validation for category properties
- **Custom Navigation**: Intuitive category listing with detailed views

### 📖 Product Management
- **Advanced Product Catalog**: Complete book management with detailed metadata
- **Multi-tier Pricing**: Support for bulk pricing (1, 50, 100+ quantities)
- **Category Integration**: Products linked to categories with navigation properties
- **Comprehensive Book Details**: ISBN, Author, Title, Description tracking
- **Upsert Operations**: Unified Create/Edit functionality for streamlined workflows

### 🏢 Areas Architecture
- **Admin Area**: Complete administrative interface for content management
  - Product management (CRUD operations)
  - Category administration
  - Dashboard and analytics views
- **Customer Area**: Customer-facing interface (ready for extension)
  - Product browsing and search capabilities
  - Shopping cart functionality (extensible)
  - User account management (planned)

## 🎨 Header & Footer Design System

### 📋 Three-Tier Header Architecture

The application features a sophisticated three-row header design that adapts seamlessly across different screen sizes:

#### **Row 1: Welcome Bar**
- **Social Media Integration**: Facebook, LinkedIn, Instagram, YouTube icons
- **Welcome Message**: "WELCOME TO BULKBOOK WEB - YOUR PREMIER ONLINE BOOK STORE!"
- **Support Information**: Phone number with icon (+8801735718761)
- **Responsive Behavior**: Hidden on small screens (≤768px) for clean mobile experience

#### **Row 2: Main Header**
- **Brand Identity**: Large BULKBOOK logo with "Web Store" tagline
- **Advanced Search**: Full-width search bar with placeholder text
- **User Actions**: Profile dropdown, wishlist, and shopping cart icons
- **Responsive Behavior**: Hidden on small screens to maximize content space

#### **Row 3: Sticky Navigation**
- **Menu Integration**: Menu button icon (large screens only)
- **Navigation Links**: Home, Category, Writer, Publication, Stationary, Campaign
- **Admin Access**: Dropdown with Dashboard, Categories, and Products links
- **Sticky Behavior**: Remains visible during scroll with enhanced visual effects

### 🔄 Responsive Header Behavior

#### **Large Screens (≥992px)**
- Full three-row header experience
- Menu button visible on the left
- Complete navigation with centered links
- All social media and contact information displayed

#### **Small Screens (≤768px)**
- **Simplified Design**: Only sticky navigation visible
- **Logo Replacement**: BULKBOOK logo replaces menu button
- **Search Integration**: Modal-based search accessible via icon
- **Clean Interface**: First two header rows hidden for optimal mobile UX

### 🦶 Professional Footer System

#### **Two-Tier Footer Design**

**Main Footer (White Background)**
- **Company Branding**: Logo, mission statement, and social media links
- **Quick Links**: Essential navigation (Home, Categories, Writers, Publications, Campaigns)
- **Customer Service**: Support links (Contact, FAQ, Shipping, Returns, Track Order)
- **Contact Information**: Phone, email, and address with intuitive icons

**Bottom Footer (Dark Background)**
- **Copyright Information**: Professional legal text
- **Developer Credit**: Attribution with animated heart icon

#### **Advanced Responsive Footer Layout**

**Large Screens (≥992px)**
```
[ Company Info ] [ Quick Links ] [ Customer Service ] [ Contact Info ]
[              Copyright              |        Developer Credit        ]
```

**Medium Screens (768px-991px)**
```
[   Company Info   ] [  Quick Links  ]
[ Customer Service ] [ Contact Info  ]
[    Copyright     |   Developer     ]
```

**Small Screens (≤767px)**
```
[        Company Info        ]
[ Quick ] [ Service ] [ Touch ]
[  Copyright  |  Developer   ]
```

### ⚡ Advanced Features & Interactions

#### **Sticky Navigation Enhancements**
- **Scroll Effects**: Visual feedback with backdrop blur and shadows
- **Hover Animations**: Footer-style link effects with slide and underline
- **Performance Optimized**: Smooth 0.3s transitions with hardware acceleration

#### **Mobile-First Design**
- **Touch-Friendly**: Optimized button sizes and spacing for mobile interaction
- **Search Modal**: Dedicated search interface for mobile users
- **Progressive Enhancement**: Features degrade gracefully across devices

#### **Visual Design Elements**
- **Clean Aesthetics**: Minimal shadows and subtle dividers (30% opacity HR elements)
- **Brand Consistency**: Unified color scheme and typography
- **Professional Spacing**: Carefully tuned padding and margins for optimal readability

### 🛠️ Technical Implementation

#### **CSS Architecture**
- **Flexbox Layout**: Modern layout system for responsive design
- **Bootstrap 5 Integration**: Utility classes with custom enhancements
- **Custom Animations**: Keyframe animations for engaging user interactions
- **Mobile-Specific Styles**: Dedicated media queries for optimal mobile experience

#### **JavaScript Functionality**
- **Scroll Detection**: Dynamic navigation styling based on scroll position
- **Modal Management**: Bootstrap modal integration for mobile search
- **Performance Monitoring**: Optimized event listeners for smooth scrolling

#### **Responsive Breakpoints**
```css
/* Small devices (landscape phones, 576px and up) */
@media (min-width: 576px) { ... }

/* Medium devices (tablets, 768px and up) */
@media (min-width: 768px) { ... }

/* Large devices (desktops, 992px and up) */
@media (min-width: 992px) { ... }

/* Extra large devices (large desktops, 1200px and up) */
@media (min-width: 1200px) { ... }
```

### 📁 Modified Files & Components

#### **Layout & Structure**
- **`Views/Shared/_Layout.cshtml`**: Complete header/footer restructure
  - Three-tier header implementation
  - Responsive navigation with conditional rendering
  - Professional two-tier footer with optimized mobile layout
  - Search modal integration for mobile devices

#### **Styling & Visual Design**
- **`wwwroot/css/site.css`**: Comprehensive styling system
  - Sticky navigation with scroll effects
  - Responsive grid layouts for footer
  - Advanced hover animations and transitions
  - Mobile-first responsive design patterns

#### **Key CSS Classes Added**
```css
.welcome-bar                 /* Top header row styling */
.main-header                 /* Middle header row layout */
.sticky-navigation           /* Sticky navigation container */
.main-footer                 /* Professional footer styling */
.bottom-footer               /* Copyright and credits section */
.footer-link                 /* Interactive footer links */
.contact-info               /* Contact information layout */
```

#### **Responsive Design Features**
```css
/* Mobile navigation enhancements */
.sticky-navigation .navbar-brand     /* Mobile logo display */
.btn-outline-primary                 /* Search button styling */

/* Footer responsive grid */
.main-footer .col-4                  /* Three-column mobile layout */
.footer-brand                        /* Brand section responsive behavior */
```

#### **Interactive Elements**
- **Scroll Detection**: JavaScript implementation for dynamic navigation styling
- **Modal Search**: Bootstrap modal for mobile search functionality
- **Hover Effects**: CSS animations for professional link interactions
- **Responsive Images**: Optimized icon sizing across devices

### 🔄 Advanced Data Management
- **Repository Pattern**: Clean data access layer with generic repositories
- **Unit of Work**: Centralized transaction management and data consistency
- **Include Properties**: Efficient eager loading of navigation properties
- **Migration Support**: Code-first database migrations with Entity Framework

### 🎨 UI/UX Features
- **Responsive Design**: Bootstrap 5 with custom CSS enhancements
- **Modern Animations**: Smooth transitions and hover effects
- **Professional Styling**: Custom gradient backgrounds and card layouts
- **Interactive Elements**: Form validation feedback and loading states
- **Pagination System**: Efficient browsing with 6 items per page
- **Notification System**: Success/error message display with TempData

### 🔧 Technical Features
- **MVVM Pattern**: Model-View-ViewModel architecture with dedicated ViewModels
- **Data Validation**: Comprehensive client and server-side validation
- **Error Handling**: Centralized error management and user feedback
- **Include Navigation**: Efficient data loading with related entities
- **Scalable Structure**: Modular design for easy feature extension

### ✅ Technical Implementation

#### 1. **Multi-Project Solution Structure**
- **BulkProject**: Main web application with Areas, controllers and views
- **Bulk.Models**: Contains entity models, ViewModels, and validation attributes
- **Bulk.DataAccess**: Repository pattern implementation with EF Core and Unit of Work
- **Bulk.Utility**: Shared utilities and constants

#### 2. **Entity Models**

**Category Entity:**
- Primary Key: `Id` (auto-increment)
- Required Properties: `Name` (1-30 characters), `DisplayOrder` (1-100 range)
- Navigation: One-to-Many relationship with Products

**Product Entity:**
- Primary Key: `Id` (auto-increment)
- Core Properties: `Title`, `Description`, `ISBN`, `Author`
- Pricing Structure:
  - `ListPrice`: Standard retail price
  - `Price`: Base selling price (1-50 qty)
  - `Price50`: Bulk pricing for 50+ quantities
  - `Price100`: Volume pricing for 100+ quantities
- Foreign Key: `CategoryId` linking to Category
- Navigation Property: `Category` for eager loading

#### 3. **View Models**

**ProductVM (Product View Model):**
```csharp
public class ProductVM
{
    public Product Product { get; set; }
    public IEnumerable<SelectListItem> CategoryList { get; set; }
}
```
- Combines Product entity with Category dropdown data
- Used in Create/Edit forms for unified data handling
- Enables clean separation between data models and UI requirements

#### 4. **Areas Architecture Implementation**

**Admin Area (`/Areas/Admin/`):**
- **Product Management**: Full CRUD operations with pagination
- **Category Management**: Administrative category operations
- **Route Structure**: `/Admin/Product/Index`, `/Admin/Category/Index`
- **Controllers**: ProductController, CategoryController with Area attribute

**Customer Area (`/Areas/Customer/`):**
- **Home Controller**: Landing page and public views
- **Extensible Structure**: Ready for shopping cart, user profiles
- **Route Structure**: `/Customer/Home/Index`

#### 5. **Pagination System**
- **Page Size**: 6 items per page for optimal loading
- **ViewBag Data**: `ViewBag.CurrentPage`, `ViewBag.TotalPages`
- **Navigation**: Previous/Next controls with page numbering
- **Performance**: Efficient data loading with Skip/Take operations

#### 6. **Database Integration**
- **PostgreSQL Database**: Production-ready database setup
- **Entity Framework Core**: Code-first migrations with navigation properties
- **Seed Data**: Pre-populated categories for testing
- **Connection String Configuration**: Externalized in appsettings.json

#### 7. **Repository Pattern Implementation**
```csharp
// Generic Repository Interface
public interface IRepository<T> where T : class
{
    T Get(Expression<Func<T, bool>> filter, string? includeProperties = null);
    IEnumerable<T> GetAll(string? includeProperties = null);
    void Add(T entity);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entities);
}

// Category-specific Repository
public interface ICategory : IRepository<Category>
{
    void Update(Category category);
}

// Product-specific Repository  
public interface IProduct : IRepository<Product>
{
    void Update(Product product);
}

// Unit of Work Pattern
public interface IUnitOfWork
{
    ICategory Category { get; }
    IProduct Product { get; }
    void Save();
}
```

**Advanced Features:**
- **Include Properties**: Support for eager loading navigation properties
- **Generic Operations**: Reusable CRUD operations across all entities
- **Unit of Work**: Centralized transaction management and data consistency
- **Expression Trees**: Flexible filtering with LINQ expressions

#### 8. **Controller Architecture**

**Product Controller (Admin Area):**
- **Index Action**: Paginated product listing with category relationships
- **Upsert Action**: Unified Create/Edit functionality
- **Delete Operations**: Soft delete with confirmation
- **Include Navigation**: Automatic loading of Category data
- **ViewBag Pagination**: Current page and total pages for UI controls

**Repository Usage Example:**
```csharp
public IActionResult Index(int page = 1)
{
    int pageSize = 6;
    var products = _unitOfWork.Product.GetAll(includeProperties: "Category");
    ViewBag.CurrentPage = page;
    ViewBag.TotalPages = (int)Math.Ceiling(products.Count() / (double)pageSize);
    return View(products.Skip((page - 1) * pageSize).Take(pageSize));
}
```

#### 9. **Data Models with Validation**

**Category Model:**
```csharp
public class Category
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(30)]
    [Display(Name = "Category Name")]
    public string Name { get; set; }
    
    [Display(Name = "Display Order")]
    [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100.")]
    public int DisplayOrder { get; set; }
}
```

**Product Model:**
```csharp
public class Product
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [Display(Name = "Title")]
    public string Title { get; set; }
    
    [Required]
    public string Description { get; set; }
    
    [Required]
    [Display(Name = "ISBN")]
    public string ISBN { get; set; }
    
    [Required]
    [Display(Name = "Author")]
    public string Author { get; set; }
    
    [Required]
    [Display(Name = "List Price")]
    [Range(1, 1000)]
    public double ListPrice { get; set; }
    
    [Required]
    [Display(Name = "Price for 1-50")]
    [Range(1, 1000)]
    public double Price { get; set; }
    
    [Required]
    [Display(Name = "Price for 50+")]
    [Range(1, 1000)]
    public double Price50 { get; set; }
    
    [Required]
    [Display(Name = "Price for 100+")]
    [Range(1, 1000)]
    public double Price100 { get; set; }
    
    [Required]
    [Display(Name = "Category")]
    public int CategoryId { get; set; }
    
    [ForeignKey("CategoryId")]
    [ValidateNever]
    public Category Category { get; set; }
}
```

## 🛠️ Technology Stack

### Backend
- **Framework**: ASP.NET Core 9.0 MVC with Areas
- **Language**: C# 12
- **Database**: PostgreSQL with Entity Framework Core
- **ORM**: Entity Framework Core with Code-First Migrations
- **Architecture**: MVC Pattern with Repository Pattern and Unit of Work
- **Areas**: Admin and Customer separation for scalable architecture

### Frontend
- **CSS Framework**: Bootstrap 5 with custom CSS enhancements
- **Icons**: Bootstrap Icons
- **JavaScript**: Vanilla JS with modern ES6+ features
- **Templating**: Razor Pages with ViewModels
- **UI Features**: Responsive design, animations, and pagination

### Development Tools
- **IDE**: Visual Studio Code / Visual Studio
- **Version Control**: Git
- **Package Manager**: NuGet

## 📋 Database Schema

### Categories Table
```sql
CREATE TABLE Categories (
    Id SERIAL PRIMARY KEY,
    Name VARCHAR(30) NOT NULL,
    DisplayOrder INTEGER CHECK (DisplayOrder >= 1 AND DisplayOrder <= 100)
);
```

### Products Table
```sql
CREATE TABLE Products (
    Id SERIAL PRIMARY KEY,
    Title VARCHAR(255) NOT NULL,
    Description TEXT NOT NULL,
    ISBN VARCHAR(50) NOT NULL,
    Author VARCHAR(255) NOT NULL,
    ListPrice DECIMAL(10,2) CHECK (ListPrice >= 1 AND ListPrice <= 1000),
    Price DECIMAL(10,2) CHECK (Price >= 1 AND Price <= 1000),
    Price50 DECIMAL(10,2) CHECK (Price50 >= 1 AND Price50 <= 1000),
    Price100 DECIMAL(10,2) CHECK (Price100 >= 1 AND Price100 <= 1000),
    CategoryId INTEGER NOT NULL,
    FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
);
```

### Seed Data
- Electronics (Display Order: 1)
- Books (Display Order: 2)
- Clothing (Display Order: 3)

## 🎯 CRUD Operations Implemented

### Product Management (Admin Area)
1. **Create Product**
   - Comprehensive form with all product properties
   - Category selection via dropdown (ProductVM)
   - Multi-tier pricing validation
   - ISBN and Author tracking

2. **Read Products**
   - Paginated product listing (6 items per page)
   - Category relationship display via Include properties
   - Efficient data loading with navigation properties
   - Search and filtering capabilities

3. **Update Product**
   - Upsert pattern for unified Create/Edit operations
   - Maintain all validation rules
   - Category reassignment support
   - Pricing tier adjustments

4. **Delete Product**
   - Confirmation-based deletion
   - Cascade considerations with categories
   - Admin-only access control

### Category Management
1. **Create Category**
   - Form validation with server-side checks
   - Duplicate name prevention
   - Display order validation (1-100)

2. **Read Categories**
   - List all categories with sorting
   - Individual category details
   - Search and filtering capabilities
   - Product count display (navigation property)

3. **Update Category**
   - Edit existing category details
   - Validation maintenance
   - Optimistic concurrency handling

4. **Delete Category**
   - Soft delete confirmation
   - Cascade delete considerations (check for related products)
   - User feedback on success/failure

## 🎨 UI/UX Features

### Modern Interface Design
- **Responsive Layout**: Mobile-first Bootstrap 5 design with custom CSS
- **Card-based Design**: Clean, modern card layouts with gradient backgrounds
- **Icon Integration**: Bootstrap Icons for intuitive navigation
- **Color Coding**: Status-based color schemes and visual feedback
- **Animation**: Smooth CSS transitions, hover effects, and loading states
- **Professional Styling**: Custom gradients, shadows, and modern typography

### User Experience
- **Notification System**: TempData-based success, error, and warning messages
- **Form Validation**: Real-time client and server validation with feedback
- **Loading States**: Visual feedback during CRUD operations
- **Confirmation Dialogs**: Safe delete operations with user confirmation
- **Pagination**: Efficient navigation with 6 items per page display
- **Breadcrumb Navigation**: Clear page hierarchy and location awareness

### Areas-based Navigation
- **Admin Interface**: Dedicated admin area for content management
- **Customer Interface**: Public-facing pages for browsing products
- **Route Separation**: Clean URL structure with area-based routing
- **Access Control**: Area-specific security and permissions (extensible)

## ⚙️ Configuration

### Database Connection
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=BulkDb;Username=postgres;Password=sazzad;"
  }
}
```

### Dependency Injection Setup
```csharp
// Program.cs configuration for Repository Pattern
builder.Services.AddDbContext<BulkDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Repository Pattern Registration
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICategory, CategoryRepository>();
builder.Services.AddScoped<IProduct, ProductRepository>();
```

### Areas Registration
```csharp
// Program.cs - Areas support
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
```

## 🚦 Getting Started

### Prerequisites
- .NET 9.0 SDK
- PostgreSQL Server (12.0 or higher)
- Visual Studio Code or Visual Studio
- Git for version control

### Installation Steps
1. **Clone the repository**
   ```bash
   git clone [repository-url]
   cd BulkBookWeb
   ```

2. **Update Database Connection**
   - Modify `appsettings.json` with your PostgreSQL credentials

3. **Run Database Migrations**
   ```bash
   dotnet ef database update --project Bulk.DataAccess
   ```

4. **Run the Application**
   ```bash
   cd BulkProject
   dotnet run
   ```

5. **Access the Application**
   - Navigate to `https://localhost:5001` or `http://localhost:5000`
   - Admin Area: `/Admin/Product/Index` for product management
   - Admin Area: `/Admin/Category/Index` for category management
   - Customer Area: `/Customer/Home/Index` for public views

## 📝 What I've Learned & Implemented

### Architecture Patterns
- ✅ **Clean Architecture**: Multi-project solution with clear boundaries
- ✅ **Repository Pattern**: Abstracted data access layer with generic repositories
- ✅ **Unit of Work Pattern**: Centralized transaction management
- ✅ **Dependency Injection**: Proper IoC container usage with repository registration
- ✅ **Separation of Concerns**: Each layer has specific responsibilities
- ✅ **Areas Architecture**: Admin/Customer separation for scalable design

### Entity Framework Core
- ✅ **Code-First Approach**: Model-driven database design with navigation properties
- ✅ **Migrations**: Database versioning and updates with relationship management
- ✅ **Seed Data**: Initial data population for categories
- ✅ **PostgreSQL Integration**: Production database setup with proper constraints
- ✅ **Include Properties**: Efficient eager loading of related entities
- ✅ **Foreign Key Relationships**: Category-Product relationships with validation

### ASP.NET Core MVC
- ✅ **Controllers**: HTTP request handling with Areas support
- ✅ **Views**: Razor template engine with ViewModels
- ✅ **Models**: Data binding and validation
- ✅ **Routing**: URL pattern configuration

### Frontend Development
- ✅ **Bootstrap Integration**: Responsive design framework
- ✅ **Form Handling**: Client and server-side validation
- ✅ **AJAX Operations**: Asynchronous data operations
- ✅ **User Interface**: Modern, accessible design

### Best Practices
- ✅ **Error Handling**: Graceful error management
- ✅ **Validation**: Input validation at multiple layers
- ✅ **ViewModels**: ProductVM for complex form scenarios with dropdown data
- ✅ **Areas**: Admin and Customer area separation
- ✅ **Routing**: Area-based routing with proper URL structure
- ✅ **TempData**: Message passing between controller actions
- ✅ **Model Binding**: Complex model binding with validation attributes
- ✅ **Action Filters**: Input validation and error handling

### Advanced Patterns & Features
- ✅ **Upsert Pattern**: Unified Create/Edit operations in controllers
- ✅ **Pagination System**: Efficient data pagination with ViewBag controls
- ✅ **Include Properties**: Navigation property management with Include()
- ✅ **Generic Repositories**: Reusable CRUD operations across entities
- ✅ **Expression Trees**: Flexible filtering with LINQ expressions
- ✅ **Multi-tier Pricing**: Complex business logic for product pricing
- ✅ **Validation Attributes**: Comprehensive model validation
- ✅ **Foreign Key Management**: Proper entity relationships and constraints

### UI/UX Implementation
- ✅ **Bootstrap 5**: Modern responsive framework
- ✅ **Custom CSS**: Professional styling with animations
- ✅ **Form Validation**: Client and server-side validation feedback
- ✅ **Notification System**: User feedback with styled messages
- ✅ **Responsive Design**: Mobile-first approach
- ✅ **Professional Animations**: CSS transitions and hover effects
- ✅ **Security**: Basic security implementations with Areas
- ✅ **Performance**: Efficient database queries with pagination

## 🎯 Future Enhancements

### Planned Features
- ✅ **Product Management**: Complete CRUD operations (IMPLEMENTED)
- [ ] User authentication and authorization with Identity
- [ ] Advanced search and filtering across products
- [ ] File upload for book covers and images
- [ ] Shopping cart functionality
- [ ] Order management system
- [ ] API endpoints for mobile integration
- [ ] Caching implementation (Redis/Memory)
- [ ] Unit testing suite
- [ ] Integration tests

### Technical Improvements
- [ ] Logging framework integration (Serilog)
- [ ] Email notification system
- [ ] Advanced error handling middleware
- [ ] Performance monitoring and analytics
- [ ] Docker containerization
- [ ] CI/CD pipeline setup

## 📊 Project Statistics

### Current Implementation Scale
- **Lines of Code**: ~2,000+ lines across all projects
- **Projects**: 4 separate projects with clean architecture
- **Controllers**: 4+ (Home, Category, Product with Areas)
- **Models**: 4+ (Category, Product, ProductVM, ErrorViewModel)
- **Views**: 15+ Razor views across Areas
- **Database Tables**: 2 (Categories, Products with relationships)
- **Repository Classes**: 6+ (Generic and specific implementations)
- **Areas**: 2 (Admin, Customer with dedicated controllers)

### Features Implemented
- ✅ **Complete Product Management**: Full CRUD with pagination
- ✅ **Category Management**: Complete administrative interface
- ✅ **Repository Pattern**: Generic repositories with Unit of Work
- ✅ **Areas Architecture**: Separated admin and customer interfaces
- ✅ **Advanced UI**: Bootstrap 5 with custom CSS and animations
- ✅ **Pagination System**: Efficient data browsing (6 items per page)
- ✅ **ViewModels**: Complex form handling with ProductVM
- ✅ **Navigation Properties**: Entity relationships with Include support
- ✅ **Multi-tier Pricing**: Complex business logic implementation
- ✅ **Professional Styling**: Modern UI with gradients and animations

## 🤝 Contributing
This is a learning project showcasing modern ASP.NET Core development practices! Contributions are welcome:
- Report bugs or suggest improvements
- Submit pull requests for new features
- Share feedback on architecture decisions
- Suggest additional patterns or best practices

## 📄 License
This project is created for educational purposes and personal learning in modern web development.

---

**Built with ❤️ using ASP.NET Core 9.0, Entity Framework Core, PostgreSQL, and modern web development practices**

*A comprehensive demonstration of clean architecture, repository patterns, Areas implementation, and professional UI design in ASP.NET Core MVC*
