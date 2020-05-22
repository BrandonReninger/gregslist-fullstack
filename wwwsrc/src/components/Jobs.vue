<template>
  <div class="jobs">
    <div class="row justify-content-center">
      <div class="col-3 m-3 border rounded" v-for="job in jobs" :key="job.id">
        <h1>{{jobs.title}}</h1>
        <h2>${{jobs.salary}}</h2>
        <p>Location: {{jobs.citystate}}</p>
      </div>
    </div>
  </div>
</template>


<script>
export default {
  name: "jobs",
  data() {
    return {};
  },
  mounted() {
    this.$store.dispatch("getJobs");
  },
  computed: {
    jobs() {
      return this.$store.state.jobs;
    }
  },
  methods: {},
  components: {}
};
</script>


<style scoped>
</style>