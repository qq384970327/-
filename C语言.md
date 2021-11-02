# C语言

```c
int main(){}//基本结构
```

### 基本语法

换行 \n

const 不变

%d 十进制  %x十六进制

### 输出文字

```c
 printf("name\n");
 printf("%d",j);//数字
 printf("%f...",x);//小数
```

`return 0;`

### 输入

```c
scanf_s("%d...,&数字");
scanf_s("%lf...");//小数
```

%d 十进制  %x十六进制

### 循环

`while(控制表达式)`

`{case常量:语句`

`default:语句}`

##### do-while

do{语句

}while(条件)

### for循环

```c
for(初始条件;循环继续条件;循环每一轮都要做的条件){}
```

break打破循环

continue跳过循环

### 跳出多重循环

```c 
if(退出==1)break;
```

```c
goto out;
out:
```



### 随机数

```c
srand(time(0));
rand();

```



