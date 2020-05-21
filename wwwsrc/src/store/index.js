import Vue from "vue";
import Vuex from "vuex";
import Axios from "axios";
import router from "../router";

Vue.use(Vuex);

let baseUrl = location.host.includes("localhost") ?
  "https://localhost:5001/" :
  "/";

let api = Axios.create({
  baseURL: baseUrl + "api/",
  timeout: 3000,
  withCredentials: true
});

export default new Vuex.Store({
  state: {
    cars: [],
    activeCar: {},
    houses: []
  },
  mutations: {
    setCars(state, cars) {
      state.cars = cars
    },
    setActiveCar(state, car) {
      state.activeCar = car
    },
    setHouses(state, houses) {
      state.houses = houses
    }
  },
  actions: {
    setBearer({}, bearer) {
      api.defaults.headers.authorization = bearer;
    },
    resetBearer() {
      api.defaults.headers.authorization = "";
    },
    async createCar({
      commit,
      dispatch
    }, newCar) {
      let res = await api.post("cars", newCar)
      dispatch("getCars")
    },

    async getCars({
      commit,
      dispatch
    }) {
      try {
        let res = await api.get("cars")
        commit("setCars", res.data)
      } catch (err) {
        alert(JSON.stringify(err));
      }
    },

    async getCar({
      commit
    }, carId) {
      try {
        let res = await api.get("/cars/" + carId)
        commit("setActiveCar", res.data)
      } catch (error) {
        console.error(error)
      }
    },

    async deleteCar({
      dispatch
    }, carId) {
      try {
        await api.delete("cars/" + carId)
        dispatch("getCars")
      } catch (error) {
        alert(JSON.stringify(error.response.data));
      }

    },

    async carDetails({
      commit,
      dispatch
    }, carId) {
      try {
        let res = await api.get('cars' + carId)
        commit('setActiveCar', res.data)
      } catch (error) {
        console.error(error)
      }
    },

    async addHouse({
      dispatch
    }, newHouse) {
      try {
        let res = await api.post('houses', newHouse)
        dispatch('getHouses')
      } catch (error) {
        console.error(error)
      }
    },

    async getHouses({
      commit
    }) {
      try {
        let res = await api.get('houses')
        commit('setHouses', res.data)
      } catch (error) {
        console.error(error)
      }
    },

    async deleteHouse({
      dispatch
    }, houseId) {
      try {
        await api.delete("houses/" + houseId)
        dispatch('getHouses')
      } catch (error) {
        console.error(error)
      }
    }

  }
});