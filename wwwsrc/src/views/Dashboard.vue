<template>
  <div class="dashboard">
    <h1>WELCOME TO THE DASHBOARD</h1>
    <create-car></create-car>
    <cars></cars>
    <houses></houses>
  </div>
</template>

<script>
import CreateCar from "../components/CreateCar.vue";
import Cars from "../components/Cars.vue";
import Houses from "../components/Houses.vue";
export default {
  mounted() {},
  computed: {},
  components: { CreateCar, Cars, Houses }
};
</script>

<style></style>
