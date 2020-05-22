<template>
  <div class="car row justify-content-center">
    <div class="col-4 border rounded">
      <h1>{{car.make}}</h1>

      <h2>{{car.model}}</h2>

      <img :src="car.imgUrl" class="img-fluid" />

      <h3>{{car.price}}</h3>

      <h3>{{car.productionYear}}</h3>

      <h3>{{car.body}}</h3>
      <div class="form-group">
        <label for="bid">Bid Amount:</label>
        <input
          type="number"
          class="form-control"
          name="bid"
          placeholder="enter bid amount"
          v-model="bidAmount"
        />
      </div>
      <button class="btn btn-info btn-block" @click="bid()">Bid</button>
      <button class="btn btn-danger btn-block" @click="deleteCar(car.id)">DELETE</button>
    </div>
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
  methods: {
    deleteCar(carId) {
      this.$store.dispatch("deleteCar", carId);
    },
    bid() {
      let tempCar = JSON.parse(JSON.stringify(this.car));
      tempCar.price = tempCar.price + +this.bidAmount;
      this.$store.dispatch("bidOnCar", tempCar);
    }
  },
  components: {}
};
</script>


<style scoped>
</style>