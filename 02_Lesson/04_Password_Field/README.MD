# Password field

**1. Equivalence partitions and 2. boundary values:**

<table>
    <tr>
        <th>Partition type</th>
        <th>Partitions</th>
        <th>Test case value</th>
        <th>Expected output</th>
        <th>Boundary values</th>
        <th>Test case values</th>
    </tr>
    <tr>
        <td>Invalid</td>
        <td>0</td>
        <td>""</td>
        <td>False</td>
        <td>0, 1</td>
        <td>"", " ", "P"</td>
    </tr>
    <tr>
        <td>Invalid</td>
        <td>1 - 4</td>
        <td>"Pa"</td>
        <td>False</td>
        <td>1, 4</td>
        <td>"", "P", "Pa", "Pas", "Pass", "Passw"</td>
    </tr>
    <tr>
        <td>Valid</td>
        <td>5 - 10</td>
        <td>"Password"</td>
        <td>True</td>
        <td>5, 10</td>
        <td>"Pass", "Passw", "Passwo", "Password1", "Password12", "Password123"</td>
    </tr>
    <tr>
        <td>InValid</td>
        <td>11 - MAX LENGTH</td>
        <td>"Password1234567890"</td>
        <td>False</td>
        <td>11</td>
        <td>"Password12", "Password123", "Password1234"</td>
    </tr>
</table>

**3. List of test cases:**

`""` `"P"` `"Pa"` `"Pass"` `"Passw"` `"Passwo"` `"Password"` `"Password1"` `"Password12"` `"Password123"` `"Password1234"` `"Password1234567890"`
