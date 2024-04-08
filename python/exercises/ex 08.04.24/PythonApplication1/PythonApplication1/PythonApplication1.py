import random
def BinariSearch(a, x):
    low=0
    up=len(a)-1
    while(low<=up):
        mid=(low+up)//2
        if(x==a[mid]):
            return mid
        if(x<a[mid]):
            up=mid-1
        else:
            low=mid+1
    return -1
def Search(a, x):
    for i in range(len(a)):
        if(a[i]==x):
            return i
    return -1
   
a=[0]*100000
a[0]=2
for i in range(1,len(a)):
    a[i]=a[i-1]+random.randint(1,6)
print(a)    
y=int(input("Enter a number : "))
print(BinariSearch(a, y))  
print(Search(a, y))

a=[1,3,4,5,6,7,22,44,55,66,77,88]
x=56

#   1*2*2*2*2*2*2*2 = 2^7   =   128
#   128/2/2/2/2/2/2/2 = 1
#   log

#--------------------------------------------------------
r=((3,"safgsd",5),(7,7,7),(2))  ## Explanation of 'tapel'
# a=(3,4,5)
# x=[2,4,a,66]

a=[4, 6, (77,66,99,11,33), 33]
print(a)
for i in range(len(a)):
   print(a[i])
a[1]=-2222
print(a[2][1])
a[2][1]=9090

t=(2,3) #   tuple
print(t)
print(t[0])
t[0]=77
 
#---------------------------------------------------
a=[             #Counter of pairs of numbers (to the side and below)
   [1,4,4,6,5,7],
   [4,3,6,9,9,9],
   [3,6,5,7,9,1],
   [9,3,7,5,7,1],
   [5,3,6,6,7,6]
]
m=0
for r in range(len(a)-1):
   for c in range(len(a[0])-1):
       if(a[r][c]==a[r][c+1]):
           m+=1
       if(a[r][c]==a[r+1][c]):
           m+=1
   #c+=1                    # option 1
   #if(a[r][c]==a[r+1][c]): #
   #    m+=1                #
 
for r in range(len(a)-1):                        # option 2
   if(a[r][len(a[0])-1]==a[r+1][len(a[0])-1]):  #
       m+=1                                     #
for c in range(len(a[0])-1):
   if(a[len(a)-1][c]==a[len(a)-1][c+1]):
       m+=1
print(m)

#------------------------------------------
a=[                   # Prints the largest number from each column
   [1,4,3,6,5,7],    
   [4,3,6,5,7,9],    # output: 9,6,7,8,7,9
   [3,6,5,7,5,1],
   [9,3,7,5,7,1],
   [5,3,6,8,7,6],
]
for c in range(len(a[0])):
   max=a[0][c]
   for r in range(1, len(a)):
       if(a[r][c]>max):
           max=a[r][c]
   print(max)




a=[1,2,3,4,5,6,7,8,9,10]   # left=z , right=e
# a=[10,2,8,4,6,5,7,3,9,1]
print(a)
right=len(a)-1
left=0
while(left<len(a) and a[left]%2==0):
   left+=1
if(left<len(a)-1):
   while(left<right and a[right]%2==1):
       right-=1
   while(left<right):
       if(a[right]%2==0 and a[left]%2==1):
           ezer=a[left]
           a[left]=a[right]
           a[right]=ezer
           right-=1
           left+=1
       else:
           if(a[right]%2==1):
               right-=1
           if(a[left]%2==0):
               left+=1
print(a)                

#--------------------------------------------------
def Mirror(m):     # Reverses the order
   left=0
   right=len(m)-1
   while(left<right):
       ezer=m[left]
       m[left]=m[right]
       m[right]=ezer
       right-=1
       left+=1

a=[1,2,3,4,5,6,7]
print(a)
Mirror(a)
print(a)
b=[1,2,3,4,5,6,7,8]
print(b)
Mirror(b)
print(b)
#  7,6,5,4,3,2,1
