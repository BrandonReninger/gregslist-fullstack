<template>
  <div class="houses">
    <div class="row justify-content-center">
      <div class="col-3 m-3 border rounded" v-for="house in housess" :key="house.id">
        <h1>{{house.bedrooms}}</h1>
        <h2>{{house.bathrooms}}</h2>
        <img :src="house.imgUrl" class="img-fluid" alt srcset />
        <h2>${{house.levels}}</h2>
        <h2>{{house.year}}</h2>
        <h2>{{house.price}}</h2>
        <h2>{{house.body}}</h2>
        <button class="btn btn-primary btn-block" @click="houseDetails">DETAILS</button>
        <button class="btn btn-danger btn-block" @click="deleteHouse(house.id)">Delete</button>
      </div>
    </div>
  </div>
</template>


<script>
export default {
  name: "houses",
  data() {
    return {};
  },
  computed: {},
  methods: {},
  components: {}
};
</script>


<style scoped>
</style>