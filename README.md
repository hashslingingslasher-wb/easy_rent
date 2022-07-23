## easy_rent an Equipment Rental Web Application
# Core User Features:
1.	Account creation/deletion
    a.	Create/edit user profile 
2.	View items available for rental
3.	Live updates to stock
4.	Pay for rentals (checkout)
5.	Save frequently rented items
6.	Schedule equipment rental
7.	Rent items for multiple days
8.	Rent items without account
9.	Intuitive/minimalistic UI
# Core Admin Features:
1.	Adjust rental prices and intervals
2.	Update items
3.	Adjust stock 
4.	Calendar view of scheduled rentals
5.	Real time stock view
# Model:
1.	Database of rental items
    a. Attributes
        i.	ID
        ii.	SKU
        iii.	Name 
        iv.	Description
        v.	Rental cost
        vi.	Interval
        vii.	Stock
    b.	Only Admin has create/delete/update permission
    c.	Stock is auto incremented/decremented each time an item gets checked out
2.	Account Database
    a.	Attributes
        i.	ID
        ii.	Username
        iii.	Email
        iv.	Password (confidential)
# Views:
1.	User views
    a.	Login
    b.	Create account/register
    c.	Browse Rentals
    d.	Item detail view
    e.	Checkout/ payment
    f.	Profile
2.	Admin Views
    a.	Item availability (real time stock)
    b.	Customers (registered users)
    c.	Rental schedule
    d.	CRUD intuitive UI
    e.	Return item
# Controller:
1.	Handle CRUD display for rental items 
    a.	Display available stock in item details (User)/item availability (Admin)
    b.	DB is consistent with admin CRUD UI
    c.	Increment/decrement stock when items are checked out/returned
2.	Handle account CRUD
3.	Maintain security for accounts
4.	Login/logout functions 
5.	Confirm and register users
6.	Handle payment transactions
    a.	Keep record of payments

