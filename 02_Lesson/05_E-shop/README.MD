# Payment checker

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
        <td>0.00</td>
        <td>0.00</td>
        <td>Error</td>
        <td>0.00</td>
        <td>0.00</td>
    </tr>
    <tr>
        <td>Valid</td>
        <td>0.01 - 300.00</td>
        <td>151.00</td>
        <td>0% Discount</td>
        <td>0.01, 0.02, 299.99, 300.00</td>
        <td>0.01, 0.02, 151.00, 299.99, 300.00</td>
    </tr>
    <tr>
        <td>Valid</td>
        <td>300.01 - 800.00</td>
        <td>550.05</td>
        <td>5% Discount</td>
        <td>300.01, 300.02, 799.99, 800.00</td>
        <td>300.01, 300.02, 550.05, 799.99, 800.00</td>
    </tr>
    <tr>
        <td>Valid</td>
        <td>800.01 - MAX DECIMAL</td>
        <td>1500.00</td>
        <td>10% Discount</td>
        <td>800.01, 800.02</td>
        <td>800.01, 800.02, 1500.00</td>
    </tr>
</table>

**3. List of test cases:**

`0.00` `0.01` `0.02` `0.98` `0.99` `1.00` `1.01` `151.00` `299.99` `300.00` `300.01` `300.02` `550.05` `799.99` `800.00` `800.01` `800.02` `1500.00`
