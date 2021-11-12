#include <stdio.h>

//输出
#if 0
int main() 
{
	printf("name\n");
	return 0;
}
#endif

//猜数游戏
#if 0
int main()
{
	int count = 0;
		int t = 0;
	srand(time(0));
	int a = rand()%100+1;
	printf("我想好一个0到100的数字了");
	do 
	{
		printf("请输入你认为的数字:");
		scanf_s("%d",&t);
		count++;
		if (t > a)
		{
			printf("你的数输大了\n");
		}
		else if (t < a)
		{
			printf("你的数输小了\n");	
		}
	} while 
		(t!=a
			
			);
	printf("恭喜你，你用了%d次猜到了答案。\n", count);
	
}
#endif

//算平均值
#if 0
int main()
{
	int number = 0;
	int x = 0;
	int cishu = 0;
	scanf_s("%d", &number);
	while (number != -1) {
		x += number;
		cishu++;
		scanf_s("%d",&number);

	}
	printf("平均值为:%f\n", 1.0 * x / cishu);
}
#endif

//求分数和
#if 0
int main()
{
	double h = 0;
	int n = 0;
	int x= 0;
	scanf_s("%d", &x);

	for (n = 1; n <= x; n++) {
		h += 1.0 / n;

	}
	printf("h=%f", h);
}
#endif

//正序分解整数
#if 0
int main() {
	int x = 0;
	int a = 1;
	int p = 1;
	int shu;
    scanf_s("%d",&x);
	int y = x;
	while (x>9)
	{
		x /= 10;
		a *= 10;
		p++;
	}
      printf("它是%d位数", p);
	  do {
		  shu=y / a;
		  
		  printf("%d", shu);
		  y%= a;
		  a /= 10;
		  
		  if (a >0) {
			  printf(" ");
		  }
	  } while (a> 0);
}
#endif
//
int main()
{
	int i, j, k;
	int a;
	scanf_s("%d", &a);
	i = a;
	j = a;
	k = a;
	
	while (i<a+3)
	{
		while (j<a+3)
		{
			while (k< a+3)
			{
				if (i != j && j != k && i != k) 
				{
					printf("%d,%d,%d", i, j, k);

				}
				k++;
			}
			j++;
		}
		i++;
	}
}