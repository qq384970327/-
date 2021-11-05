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

绑定实体 public Rigidbody2D ~~;

Constraints 锁定位置

#### 函数

void FixedUpdate(){}

#### 移动



```c#
float horizontalmove=Input.GetAxis("Horizontal");//横向移动
if(horizontalmove!=0){
    rb.velovity=new vector2(horizontalmove*speed,rb.velocityw.y);
}
```

#### 跳跃

```c#
float facedircetion=Input.GetAxisRaw("Horizontal");
if(facediretion!=0){
    transform.localScale=new Vector3(facedircetion,1,1);
}
```

