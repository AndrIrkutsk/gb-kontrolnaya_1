arr = ["Hello", "2", "world", ":-)"]
# arr = ["1234", "1567", "-2", "computer science"]
# arr = ["Russia", "Denmark", "Kazan"]
newArr = []

for item in arr:     
    if (len(item) <= 3):
        newArr.append(item)
print(newArr)