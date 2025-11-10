import { createSlice, createAsyncThunk } from '@reduxjs/toolkit';
import { getOrders, addOrder, updateOrder, deleteOrder } from '../../api/ordersService';

export const fetchOrders = createAsyncThunk('orders/fetchOrders', async () => {
  const response = await getOrders();
  return response;
});

const ordersSlice = createSlice({
  name: 'orders',
  initialState: { list: [], status: 'idle' },
  reducers: {},
  extraReducers: (builder) => {
    builder.addCase(fetchOrders.fulfilled, (state, action) => {
      state.list = action.payload;
      state.status = 'succeeded';
    });
  }
});

export default ordersSlice.reducer;
