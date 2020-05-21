<template>
  <div class="dashboard">
    <h1>WELCOME TO THE DASHBOARD</h1>
    <div class="row">
      <div class="col-4 ml-2">
        <create-car></create-car>
      </div>
      <div class="col-4">
        <create-house></create-house>
      </div>
    </div>
    <cars></cars>
  </div>
</template>

<script>
import CreateCar from "../components/CreateCar.vue";
import Cars from "../components/Cars.vue";
import CreateHouse from "../components/CreateHouse.vue";
export default {
  mounted() {},
  computed: {},
  components: { CreateCar, Cars, CreateHouse }
};
</script>

<style></style>
