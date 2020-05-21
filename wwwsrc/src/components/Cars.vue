<template>
  <div class="cars">
    <div class="row justify-content-center">
      <div class="col-3 m-3 border rounded" v-for="car in cars" :key="car.id">
        <h1>{{car.make}}</h1>
        <h2>{{car.model}}</h2>
        <img :src="car.imgUrl" class="img-fluid" alt srcset />
        <h2>${{car.price}}</h2>
        <h2>{{car.year}}</h2>
        <h2>{{car.body}}</h2>
        <button class="btn btn-primary btn-block" @click="carDetails">DETAILS</button>
        <button class="btn btn-danger btn-block" @click="deleteCar(car.id)">Delete</button>
      </div>
    </div>
  </div>
</template>


<script>
export default {
  name: "cars",
  data() {
    return {};
  },
  mounted() {
    this.$store.dispatch("getCars");
  },
  computed: {
    cars() {
      return this.$store.state.cars;
    }
  },
  methods: {
    deleteCar(carId) {
      this.$store.dispatch("deleteCar", carId);
    },
    carDetails() {
      // console.log(this.activeCar);
      this.$store.commit("setActiveCar");
      this.$store.dispatch("carDetails", this.carData.id);
      this.$router.push({
        name: "CarDetails",
        params: { carId: this.carData.id }
      });
    }
  },
  components: {}
};
</script>


<style scoped>
</style>