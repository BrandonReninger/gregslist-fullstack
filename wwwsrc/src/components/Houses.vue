<template>
  <div class="houses">
    <div class="row justify-content-center">
      <div class="col-3 m-3 border rounded" v-for="house in houses" :key="house.id">
        <h1>Beds: {{house.bedrooms}}</h1>
        <h2>Baths: {{house.bathrooms}}</h2>
        <img :src="house.imgUrl" class="img-fluid" alt srcset />
        <h2>${{house.price}}</h2>
        <button class="btn btn-primary btn-block">DETAILS</button>
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
  mounted() {
    this.$store.dispatch("getHouses");
  },
  computed: {
    houses() {
      return this.$store.state.houses;
    }
  },
  methods: {
    deleteHouse(houseId) {
      // console.log("delhouse", houseId);
      this.$store.dispatch("deleteHouse", houseId);
    }
  },
  components: {}
};
</script>


<style scoped>
</style>