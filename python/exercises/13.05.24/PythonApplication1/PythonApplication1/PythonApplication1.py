# def CountEvenDigits(x):

#     if(x>0):
#         if(x % 2 == 0):
#             return 1 + CountEvenDigits(x//10)
#         else:
#             return 0 + CountEvenDigits(x // 10)
#     return 0

# print(CountEvenDigits(346))
# print(CountEvenDigits(125478966))


# def F(x,y):
#     if(y==0):
#         return 1
#     if(y%2==0):
#         return F(x*x,y//2)
#     return F(x*x,y//2)*x
# print(F(2,5))
# print(F(2,9))

# print(F(2,4))
# print(F(-2,5))

#def Mool(x,y):


m=4
k=11
r=0
while(m>0):
    r=r+k
    m=m-1
print(r)

        

        


