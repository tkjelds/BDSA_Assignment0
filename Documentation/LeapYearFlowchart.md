:::mermaid
graph TD
A[Start]-->B{year % 4 != 0};
B-->|false|C[return false];
B-->|true|D{year % 100 == 0 && year % 400 != 0};
D-->|false|C;;
D-->|true|E[return true];;
:::

:::mermaid
graph LR
A[Year integer]-->B((start));
B-->C{year % 4 != 0};
C-->|false| D[return false];
C-->|true| E{year % 100 == 0 && year % 400 != 0};
E-->|false| D;
E-->|true|F[return true];
F --> G((End));
D --> G;
:::