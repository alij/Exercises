<template>
    <div class="shopping-list">
        <h1>Shopping List Items</h1>
        <ul>
            <li>{{items[0].Name}}</li>
            <li class="completed">{{items[1].Name}}</li>
            <li>{{items[2].Name}}</li>
            <li>{{items[3].Name}}</li>
            <li class="completed">{{items[4].Name}}</li>
        </ul>
    </div>
</template>

<script>
export default {
    name: 'shopping-item',
    data() {
        return {
            items: [
                {Name: "Oatmeal"},
                {Name: "Milk"},
                {Name: "Orange Juice"},
                {Name: "Eggs"},
                {Name: "Cereal"}
            ]
        }
    }
}
</script>

<style>
div.main {
    margin: 1rem 0;
}

.shopping-list {
    width:450px;
    background: #fff;
    margin: 50px auto;
    font-family: 'Roboto Condensed', sans-serif;
    border-radius: 10px;
}
h1 {
    background:#f2f2f2;
    color:#5c8578;
    padding:10px;
    font-size:24px;
    text-transform: uppercase;
    text-align: center;
    margin-bottom: 0px;
    border-top-left-radius: 10px;
    border-top-right-radius: 10px;
}
ul {
    list-style-type: none;
    margin:0px;
    padding:0px;
}
li {
    font-size: 24px;
    border-bottom:1px solid #f2f2f2;
    padding:10px 20px;
}
li:last-child{
    border:0px;
}
li.completed {
    text-decoration: line-through;
    color:darkgrey;
}
</style>