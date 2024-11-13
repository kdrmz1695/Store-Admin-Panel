# Store-Admin-Panel

Store-Admin-Panel is a Windows Forms application developed in C# with Visual Studio. It allows users to manage a product database through a user-friendly interface with features for adding, updating, deleting, searching, and sorting products by various criteria. This application supports CRUD (Create, Read, Update, Delete) operations and includes real-time search and category filtering.

## Features

- **Add Products**: Add new products with name, price, and category.
- **Update Products**: Modify existing product details.
- **Delete Products**: Mark products as deleted (soft delete).
- **Search Products**: Search for products by name in real time.
- **Filter by Category**: Display products by selected category.
- **Sort Products**: Sort products alphabetically (A-Z, Z-A) or by price (Lowest, Highest).

## Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/kdrmz1695/Store-Admin-Panel.git

## Usage
**1.Launch the Application**
 - Open the application through Visual Studio or as a standalone executable.
   
**2.Main Functionalities:**
 - **Add Product:** Enter product name, price, and category, then click Add. Validation ensures non-empty values for product name and a valid price.
 - **Update Product:** Select a product by its ID, modify the details in the input fields, and click Update
 - **Delete Product:** Select a product by its ID and click Delete to mark it as deleted.
 - **Search Product:** Type in the search bar to filter products by name in real time.
 - **Sort Products:** Use the dropdown to sort products alphabetically or by price.
 - **Filter by Category:** Select a category to display only products within that category.

  ## Code Overview
   - **Form1.cs:** The main form that handles the UI interactions and calls database operations.
   - **CRUD Operations:**
      - **buttonPAdd_Click:** Adds a new product with validations.
      - **buttonPUp_Click:** Updates an existing product’s details.
      - **buttonPDel_Click:** Soft deletes a product.
   - **List and Search:**
       - **getList:** Lists products with filtering for non-deleted items.
       - **textBoxSearch_TextChanged:** Implements real-time search by product name.
     
   - **Sorting and Filtering:**
      - **comboBoxShortby_SelectedIndexChanged**  Handles product sorting by name or price.
      - **comboBoxCategoryList_SelectedValueChanged:** Filters products by selected category.
         
  ## Requirements
   - **Visual Studio** with Windows Forms support
   - **.Net Framework**
   - **Database:** Ensure you have a compatible database for storing product and category data.



