# sum=int(input("enter a number :"))
# n=0
# e=0
# e=e+sum%10
# sum=sum//10
# n=n+sum%10
# sum=sum//10
# print(e,n,sum)

# a=[56,72,8,124,10,3]
# ezer=a[0]
# for i in range(1,len(a)):
#     a[i-1] = a[i]
# a[i]=ezer
# print(a)


# a=[2,7,4,23,56,199,77,6]
# max=a[0]
# for i in range(1,len(a)):
#     if(max < a[i]):
#         max=a[i]
# print(max)

a=[345,789,67,512,21,4]
for i in range(len(a)):
    max=0
    while(a[i]>0):
        if(max<a[i]%10):
            max=a[i]%10
        a[i]=a[i]//10
    a[i]=max
print(a)