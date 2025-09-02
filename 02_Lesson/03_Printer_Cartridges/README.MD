# Printer Cartridges

**1. and 2. Equivalence partitions and 3-value boundary value analysis:**

| Partition type |      Partitions | Test case values | Expected output | Boundary values | Test case values |
| -------------- | --------------: | ---------------: | --------------: | --------------: | ---------------: |
| Invalid        | MIN INTEGER- -1 |              -15 |           Error |              -1 |          -2 -1 0 |
| Invalid        |               0 |                0 |           Error |               0 |           -1 0 1 |
| Invalid        |             1-4 |                2 |           Error |             1 4 |      0 1 2 3 4 5 |
| Valid          |            5-99 |               47 |     0% discount |            5 99 |  4 5 6 98 99 100 |
| Valid          | 100-MAX INTEGER |              167 |    20% discount |             100 |       99 100 101 |

**3. List of test cases:**

`-15` `-2` `-1` `0` `1` `2` `3` `4` `5` `6` `47` `98` `99` `100` `101` `167`
