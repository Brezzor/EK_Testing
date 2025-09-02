# Printer Cartridges

**1. and 2. Equivalence partitions and 3-value boundary value analysis:**

| Partition type |     Partition     | Value | Boundary values  |      Test cases      |
| :------------: | :---------------: | :---: | :--------------: | :------------------: |
|    Invalid     |       0 - 4       |   2   |       0, 4       |    0, 1, 3, 4, 5     |
|     Valid      |      5 - 99       |  54   |      5, 99       | 4, 5, 6, 98, 99, 100 |
|     Valid      | 100 - MAX INTEGER |  150  | 100, MAX INTEGER |     99, 100, 101     |

**3. List of test cases:**

`0` `1` `2` `3` `4` `5` `6` `47` `98` `99` `100` `101` `167`
