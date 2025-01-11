scores = [1,2,3,4,5,6,7,8,9]
############################# writing
file = open("hello","w")
for i in scores:
    file.write(str(i))
    file.write("\n")
file.close()
############################# appending
file = open("hello","a")
file.write("thanks")
file.close()
############################# reading
file = open("hello","r")
content = file.read()
print(content)
file.close()

