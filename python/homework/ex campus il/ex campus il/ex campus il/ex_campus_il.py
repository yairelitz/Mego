sum=int(input("enter a number :"))
n=0
e=0
e=e+sum%10
sum=sum//10
n=n+sum%10
sum=sum//10
print(e,n,sum)


