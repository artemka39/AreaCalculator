SELECT Product.name, Category.name
FROM Product
LEFT JOIN ProductCategory
ON Product.id = product_id
LEFT JOIN Category
ON category_id = Category.id