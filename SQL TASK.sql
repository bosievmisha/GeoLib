SELECT prod.name [��� ��������], cat.name [��� ���������]
FROM Products AS prod
LEFT JOIN ProductsCategory AS prodcat ON prod.id = prodcat.products_id
INNER JOIN Category AS cat ON cat.id = prodcat.category_id
ORDER BY prod.name