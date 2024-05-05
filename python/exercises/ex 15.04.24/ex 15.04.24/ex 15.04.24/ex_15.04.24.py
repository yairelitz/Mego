# s=input("Enter a string : ")
# i=0
# c=0
# while(i<len(s)-1):
#    if(s[i]=='A'):
#       if(s[i+1]=='A'):
#          break
#       c+=1
#    i+=1
# if(i<len(s)-1):
#    print("NO")
# else:  
#     if(s[i]=='A'):
#        c+=1
#     if(c>1):
#        print("YES")
#     else:
#        print("NO")
       
# #---------------------------------------------

# def IsPeak(a, i):
#     if(i==0 or i==len(a)-1):
#         return False
#     if(a[i-1]<a[i] and a[i+1]<a[i]):
#         return True
#     return False
# a=[1,2,3,4,5,5,6,4,5,6,2,3,3,2,1,2,1,3,4,2,3,1]
# c=0
# for i in range(1, len(a)-1):
#     if(IsPeak(a, i)==True):
#         c+=1
# print(c)

# #-------------------------------------------
       
# for i in range(3):
#     s=input("Enter a string : ")
#     i=0
#     c=0
#     while(i<len(s)-1):
#        if(s[i]=='A'):
#           if(s[i+1]=='A'):
#              break
#           c+=1
#        i+=1
#     if(i<len(s)-1):
#        print("NO")
#     else:  
#         if(s[i]=='A'):
#            c+=1
#         if(c>1):
#            print("YES")
#         else:
#            print("NO")
# print(m)

# #-------------------------------------

# def A(l):
#     if(len(l)%2==1):
#         return False
#     else:
#         c=-11
#         t=[0]*len(l)
#         for a in range(len(l)):
#             if(t[a]==0):
#                 c=1
#                 t[a]=1
#                 for b in range(a+1, len(l)):
#                     if(l[a]==l[b]):
#                         c+=1
#                         t[b]=1
#             if(c!=2):
#                 return False
#         return True
# l=[1, 3, 4, 2, 5, 2, 1, 3, 5, 4, 6, 6]
# print(A(l))

# #--------------------------------------------


# m=0
# for i in range(3):
#     s=input("Enter a string : ")
#     i=0
#     c=0
#     while(i<len(s)-1):
#        if(s[i]=='A'):
#           if(s[i+1]=='A'):
#              break
#           c+=1
#        i+=1
#     if(i==len(s)-1):
#         if(s[i]=='A'):
#            c+=1
#         if(c>1):
#            m+=1
# print(m)

# #------------------------------------------------

# n1=int(input("Enter first number : "))
# n2=int(input("Enter second number : "))
# c=0
# s=0
# e=0
# while(n1*(-1)!=n2):
#    c+=2
#    if(n1>0):
#       s+=n1
#    if(n2>0):
#       s+=n2
#    if(n1==n2):
#       e+=1
#    n1=int(input("Enter first number : "))
#    n2=int(input("Enter second number : "))
# print(c, s, e)

# #----------------------------------------

# def IsPeak(arr, index):
#     if(index==0 or index==len(arr)-1):
#         return False
#     if(arr[index-1]<arr[index] and arr[index+1]<arr[index]):
#         return True
#     return False
# a=[1,2,3,4,5,5,6,4,5,6,2,3,3,2,1,2,1,3,4,2,3,1]
# c=0
# for i in range(1, len(a)-1):
#     if(IsPeak(a, i)==True):
#         c+=1
# print(c)

# #-----------------------------------------------

# import random
# def G(num):
#     a=[0]*num
#     for i in range(num):
#         x=random.randint(10, 99)
#         while(x//10>=x%10):
#             x=random.randint(10, 99)
#         a[i]=x
#     print(a)
# G(22)  

# #----------------------------------------------

# def F(a):
#     if(len(a)%3!=0):
#         return False
#     left=0
#     right=len(a)//3
#     while(right<len(a) and a[left]==a[right]):
#         left+=1
#         right+=1
#     if(right==len(a)):
#         return True
#     return False
   
# r=[1,2,3,4,1,2,3,4,1,2,3,4,1,2,3,4,1,2,3,4,1,2,3,4]
# print(F(r))

#------------------------------------------------------------------

# def WWW(a,v):
#     m=0
#     for r in range(len(a)):
#         for c in range (len(a[0])-1):
#             if(a[r][c]==v and a[r][c+1]==v):
#                 m+=1
#     return m
# a=[
#     [1,1,5,2,6,3,9,8,7,4],
#     [1,1,5,2,6,3,5,8,5,6],
#     [7,8,8,8,5,9,6,3,2,1],
#     [6,4,1,5,5,6,3,5,8,7],
#     [1,1,5,2,6,3,6,9,9,8]
#     ]
# print(WWW(a,1))
# print(WWW(a,5))
# print(WWW(a,0))

#------------------------------------------------------------------


# def HHH(a):
#     for r in range(len(a)):
#         for c in range(len(a[0])):
#             print(a[r][c], end=" ")
#         print()
# a=[
#     [1,9,3,6,5],
#     [3,2,3,4,0],
#     [0,8,3,4,5],
#     [7,2,3,4,1]
# ]
# for c in range(len(a[0])):
#     temp=a[0][c]
#     for r in range(len(a)-1):
#         a[r][c] = a[r+1][c]
#     a[r+1][c]=temp
    
# HHH(a)



