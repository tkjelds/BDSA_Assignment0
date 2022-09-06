:::mermaid
graph TD
A[Start]-->B{year % 4 != 0};
B-->|false|C[return false];
B-->|true|D{year % 100 == 0 && year % 400 != 0};
D-->|false|C;;
D-->|true|E[return true];;
:::