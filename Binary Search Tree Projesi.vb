Binary Search Tree Projesi


[7, 5, 1, 8, 3, 6, 0, 9, 4, 2] dizisinin Binary-Search-Tree aşamalarını yazınız.

Örnek: root x'dir. root'un sağından y bulunur. Solunda z bulunur vb.


root'u 5 olarak aldık

                         5
                        / \
                      3     7         3, 5'ten küçük  5'in soluna // 7, 5'ten büyük sagına
                     / \   / \        1, 3'ten küçük  3'ün soluna // 4, 3'ten büyük sagına
                    1   4 6   8       6, 7'den küçük  7'nin soluna // 8, 7'den büyük sagına
                   / \         \      0, 1'den küçük  1'nin soluna // 2, 1'den büyük sagına
                  0   2         9     9, 8'den büyük