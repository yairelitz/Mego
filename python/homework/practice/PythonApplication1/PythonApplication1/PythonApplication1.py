# def Mull(a,b):
#     if (a<b):
#         r=0
#         while(a>0):
#             r=r+b
#             a-=1
#     else:
#         r=0
#         while(b>0):
#             r=r+a
#             b-=1
#     return r


# print(Mull(4,11))
# print(Mull(3,12))
# print(Mull(9,7))


# a=[1234,589,65,8,7452,691400325]
# for i in range(len(a)):
#     c=0
#     while(a[i]>0):
#         c+=1
#         a[i]=a[i]//10
#     a[i]=c
# print(a)


# a=[1234,589,65,8,7452,691400325]
# for i in range(len(a)):
#     while(a[i]>9):
#         a[i]=a[i]//10
# print(a)


# a=[1234,589,65,8,7452,691400325]
# for i in range(len(a)):
#     s=0
#     while(a[i]>0):
#         s=s+a[i]%10
#         a[i]=a[i]//10
#     a[i]=s
# print(a)


# a=[94321,6347,902563,9014,906,5]       # the largest number of any index
# for i in range(len(a)):
#     max=0
#     while(a[i]>0):
#         if(max<a[i]%10):
#             max=a[i]%10
#         else:a[i]=a[i]//10
#     a[i]=max
# print(a)


