# unity2D

##### 图层

Sorting Layer 图层前后 越下越优先

Order in Layer 顺序 数字越大越优先

#### 实体

##### 刚体 Rigidbody 2D

Gravity Scale 重力

##### 承载实体内容

2D Object→Sorite

##### 碰撞箱 Box Collider 2D



#### 地图实体 Tilemap Collider 2D



### 代码

public 公开

private 私密

显示私密[SerializeField]

获得私密的方法 对应赋名=GetComponent\<对应名称>()；

绑定实体 public Rigidbody2D 赋名;

Constraints 锁定位置

```c#
Mathf.Abs()//绝对值
```



#### 函数

void FixedUpdate(){}

#### 移动

```c#
float horizontalmove=Input.GetAxis("Horizontal");//横向移动
if(horizontalmove!=0){
    rb.velovity=new vector2(horizontalmove*speed*Time.deltaTime,rb.velocityw.y);
}
```

#### 转向

```c#
float facedircetion=Input.GetAxisRaw("Horizontal");
if(facediretion!=0){
    transform.localScale=new Vector3(facedircetion,1,1);
}
```

#### 跳跃

```c#
public float jumpforce;
if(Input.GetButtonDown("Jump")){
    rb.velocity=new Vector2(rb.velocity.x,jumpforce*Time.deltaTime);
}
```





## 创建动画

##### 基本

idle 站立

创建动画承载Animator

控制动画Create→Animator Controller

创建动画 Window→Animation→Animation

动画关系Window→Animation→Animator

设计变量public Animator anim;

##### 动画对应条件

```c#
~~~.SetFloat("running",Mathf.Abs(facedircetion))
```

##### 改变条件

```c#
anim.SetBool("jumping", true);
//与unity动画关系相联系
```

#### 设置地图

```c#
public LayerMask ground;
```

设置所属图层

```c#
public Collider2D coll;//设置对撞机
```

判断碰撞

```c#
if(coll.IsTouchingLayers(ground));
```

## 镜头控制

创造控制载体

```c#
public Transform player;
```

