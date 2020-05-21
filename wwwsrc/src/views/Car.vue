<template>
  <div class="car">
    <h1>{{car.make}}</h1>

    <h2>{{car.model}}</h2>

    <img :src="car.imgUrl" class="img-fluid" />

    <h3>{{car.price}}</h3>

    <h3>{{car.productionYear}}</h3>

    <h3>{{car.body}}</h3>
  </div>
</template>


<script>
export default {
  name: "car",
  data() {
    return {};
  },
  mounted() {
    this.$store.dispatch("getCar", this.$route.params.carId);
  },
  computed: {
    car() {
      // console.log(this.$store.state.activeCar);
      return this.$store.state.activeCar;
    }
  },
  methods: {},
  components: {}
};
</script>


<style scoped>
</style>