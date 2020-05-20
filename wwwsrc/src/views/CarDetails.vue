<template>
  <div class="car-details">
    <div class="row">
      <div class="col-12">
        <h1>{{car.make}}</h1>
      </div>
      <div class="col-12">
        <h2>{{car.model}}</h2>
      </div>
      <div class="col-6">
        <img :src="car.imgurl" class="img-fluid" />
      </div>
      <div class="col-4">
        <h3>{{car.price}}</h3>
      </div>
      <div class="col-4">
        <h3>{{car.year}}</h3>
      </div>
      <div class="col-4">
        <h3>{{car.body}}</h3>
      </div>
    </div>
  </div>
</template>


<script>
export default {
  name: "car-details",
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