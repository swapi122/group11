




/*
'===============================================================================
'  LayerHelper.CAQ.BL.TienAnDoiTuongManagerBase
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LayerHelper.CAQ.BLL;
using LayerHelper.CAQ.DAL;
using LayerHelper.CAQ.DAL.EntityClasses;
using LayerHelper.CAQ.DAL.FactoryClasses;
using LayerHelper.CAQ.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LayerHelper.CAQ.BLL
{
	public class TienAnDoiTuongManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public TienAnDoiTuongManagerBase()
		{
			// Nothing for now.
		}
		
		public TienAnDoiTuongEntity Insert(TienAnDoiTuongEntity _TienAnDoiTuongEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_TienAnDoiTuongEntity, true);
			}
			return _TienAnDoiTuongEntity;
		}

		
		public TienAnDoiTuongEntity Insert(Guid Id, Guid IdDoiTuong, string MaSuuTra, Guid IdLoaiDoiTuong, DateTime NgayBat, DateTime NgayTha, string VaiTro, string MucAn, Guid IdLoaiTienAn, string TongHop, string MaRutGon, string MaTp, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			TienAnDoiTuongEntity _TienAnDoiTuongEntity = new TienAnDoiTuongEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TienAnDoiTuongEntity.Id = Id;
				_TienAnDoiTuongEntity.IdDoiTuong = IdDoiTuong;
				_TienAnDoiTuongEntity.MaSuuTra = MaSuuTra;
				_TienAnDoiTuongEntity.IdLoaiDoiTuong = IdLoaiDoiTuong;
				_TienAnDoiTuongEntity.NgayBat = NgayBat;
				_TienAnDoiTuongEntity.NgayTha = NgayTha;
				_TienAnDoiTuongEntity.VaiTro = VaiTro;
				_TienAnDoiTuongEntity.MucAn = MucAn;
				_TienAnDoiTuongEntity.IdLoaiTienAn = IdLoaiTienAn;
				_TienAnDoiTuongEntity.TongHop = TongHop;
				_TienAnDoiTuongEntity.MaRutGon = MaRutGon;
				_TienAnDoiTuongEntity.MaTp = MaTp;
				_TienAnDoiTuongEntity.LoaiDanhMuc = LoaiDanhMuc;
				_TienAnDoiTuongEntity.IdNguoiTao = IdNguoiTao;
				_TienAnDoiTuongEntity.NgayTao = NgayTao;
				_TienAnDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TienAnDoiTuongEntity.NgayCapNhat = NgayCapNhat;
				_TienAnDoiTuongEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TienAnDoiTuongEntity, true);
			}
			return _TienAnDoiTuongEntity;
		}

		public TienAnDoiTuongEntity Insert(Guid IdDoiTuong, string MaSuuTra, Guid IdLoaiDoiTuong, DateTime NgayBat, DateTime NgayTha, string VaiTro, string MucAn, Guid IdLoaiTienAn, string TongHop, string MaRutGon, string MaTp, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			TienAnDoiTuongEntity _TienAnDoiTuongEntity = new TienAnDoiTuongEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_TienAnDoiTuongEntity.IdDoiTuong = IdDoiTuong;
				_TienAnDoiTuongEntity.MaSuuTra = MaSuuTra;
				_TienAnDoiTuongEntity.IdLoaiDoiTuong = IdLoaiDoiTuong;
				_TienAnDoiTuongEntity.NgayBat = NgayBat;
				_TienAnDoiTuongEntity.NgayTha = NgayTha;
				_TienAnDoiTuongEntity.VaiTro = VaiTro;
				_TienAnDoiTuongEntity.MucAn = MucAn;
				_TienAnDoiTuongEntity.IdLoaiTienAn = IdLoaiTienAn;
				_TienAnDoiTuongEntity.TongHop = TongHop;
				_TienAnDoiTuongEntity.MaRutGon = MaRutGon;
				_TienAnDoiTuongEntity.MaTp = MaTp;
				_TienAnDoiTuongEntity.LoaiDanhMuc = LoaiDanhMuc;
				_TienAnDoiTuongEntity.IdNguoiTao = IdNguoiTao;
				_TienAnDoiTuongEntity.NgayTao = NgayTao;
				_TienAnDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_TienAnDoiTuongEntity.NgayCapNhat = NgayCapNhat;
				_TienAnDoiTuongEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_TienAnDoiTuongEntity, true);
			}
			return _TienAnDoiTuongEntity;
		}

		public bool Update(TienAnDoiTuongEntity _TienAnDoiTuongEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(TienAnDoiTuongFields.Id == _TienAnDoiTuongEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_TienAnDoiTuongEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(TienAnDoiTuongEntity _TienAnDoiTuongEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_TienAnDoiTuongEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid IdDoiTuong, string MaSuuTra, Guid IdLoaiDoiTuong, DateTime NgayBat, DateTime NgayTha, string VaiTro, string MucAn, Guid IdLoaiTienAn, string TongHop, string MaRutGon, string MaTp, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TienAnDoiTuongEntity _TienAnDoiTuongEntity = new TienAnDoiTuongEntity(Id);
				if (adapter.FetchEntity(_TienAnDoiTuongEntity))
				{
				
					_TienAnDoiTuongEntity.IdDoiTuong = IdDoiTuong;
					_TienAnDoiTuongEntity.MaSuuTra = MaSuuTra;
					_TienAnDoiTuongEntity.IdLoaiDoiTuong = IdLoaiDoiTuong;
					_TienAnDoiTuongEntity.NgayBat = NgayBat;
					_TienAnDoiTuongEntity.NgayTha = NgayTha;
					_TienAnDoiTuongEntity.VaiTro = VaiTro;
					_TienAnDoiTuongEntity.MucAn = MucAn;
					_TienAnDoiTuongEntity.IdLoaiTienAn = IdLoaiTienAn;
					_TienAnDoiTuongEntity.TongHop = TongHop;
					_TienAnDoiTuongEntity.MaRutGon = MaRutGon;
					_TienAnDoiTuongEntity.MaTp = MaTp;
					_TienAnDoiTuongEntity.LoaiDanhMuc = LoaiDanhMuc;
					_TienAnDoiTuongEntity.IdNguoiTao = IdNguoiTao;
					_TienAnDoiTuongEntity.NgayTao = NgayTao;
					_TienAnDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_TienAnDoiTuongEntity.NgayCapNhat = NgayCapNhat;
					_TienAnDoiTuongEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_TienAnDoiTuongEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TienAnDoiTuongEntity _TienAnDoiTuongEntity = new TienAnDoiTuongEntity(Id);
				if (adapter.FetchEntity(_TienAnDoiTuongEntity))
				{
					adapter.DeleteEntity(_TienAnDoiTuongEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("TienAnDoiTuongEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienAnDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDoiTuong(Guid IdDoiTuong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienAnDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaSuuTra(string MaSuuTra)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.MaSuuTra == MaSuuTra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienAnDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdLoaiDoiTuong(Guid IdLoaiDoiTuong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdLoaiDoiTuong == IdLoaiDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienAnDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayBat(DateTime NgayBat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.NgayBat == NgayBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienAnDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTha(DateTime NgayTha)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.NgayTha == NgayTha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienAnDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByVaiTro(string VaiTro)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.VaiTro == VaiTro);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienAnDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMucAn(string MucAn)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.MucAn == MucAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienAnDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdLoaiTienAn(Guid IdLoaiTienAn)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdLoaiTienAn == IdLoaiTienAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienAnDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTongHop(string TongHop)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.TongHop == TongHop);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienAnDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienAnDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienAnDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienAnDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienAnDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienAnDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienAnDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienAnDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("TienAnDoiTuongEntity", filter);
			}
			return toReturn;
		}
		

		
		public TienAnDoiTuongEntity SelectOne(Guid Id)
		{
			TienAnDoiTuongEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				TienAnDoiTuongEntity _TienAnDoiTuongEntity = new TienAnDoiTuongEntity(Id);
				if (adapter.FetchEntity(_TienAnDoiTuongEntity))
				{
					toReturn = _TienAnDoiTuongEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectAllLST()
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, null, 0, null);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _TienAnDoiTuongCollection;
		}


		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByIdDoiTuongLST(Guid IdDoiTuong)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByIdDoiTuongLST_Paged(Guid IdDoiTuong, int PageNumber, int PageSize)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDoiTuongRDT(Guid IdDoiTuong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDoiTuongRDT_Paged(Guid IdDoiTuong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByMaSuuTraLST(string MaSuuTra)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.MaSuuTra == MaSuuTra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByMaSuuTraLST_Paged(string MaSuuTra, int PageNumber, int PageSize)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.MaSuuTra == MaSuuTra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaSuuTraRDT(string MaSuuTra)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.MaSuuTra == MaSuuTra);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaSuuTraRDT_Paged(string MaSuuTra, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.MaSuuTra == MaSuuTra);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByIdLoaiDoiTuongLST(Guid IdLoaiDoiTuong)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdLoaiDoiTuong == IdLoaiDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByIdLoaiDoiTuongLST_Paged(Guid IdLoaiDoiTuong, int PageNumber, int PageSize)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdLoaiDoiTuong == IdLoaiDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdLoaiDoiTuongRDT(Guid IdLoaiDoiTuong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdLoaiDoiTuong == IdLoaiDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdLoaiDoiTuongRDT_Paged(Guid IdLoaiDoiTuong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdLoaiDoiTuong == IdLoaiDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByNgayBatLST(DateTime NgayBat)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.NgayBat == NgayBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByNgayBatLST_Paged(DateTime NgayBat, int PageNumber, int PageSize)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.NgayBat == NgayBat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayBatRDT(DateTime NgayBat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.NgayBat == NgayBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayBatRDT_Paged(DateTime NgayBat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.NgayBat == NgayBat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByNgayThaLST(DateTime NgayTha)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.NgayTha == NgayTha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByNgayThaLST_Paged(DateTime NgayTha, int PageNumber, int PageSize)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.NgayTha == NgayTha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayThaRDT(DateTime NgayTha)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.NgayTha == NgayTha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayThaRDT_Paged(DateTime NgayTha, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.NgayTha == NgayTha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByVaiTroLST(string VaiTro)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.VaiTro == VaiTro);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByVaiTroLST_Paged(string VaiTro, int PageNumber, int PageSize)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.VaiTro == VaiTro);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByVaiTroRDT(string VaiTro)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.VaiTro == VaiTro);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByVaiTroRDT_Paged(string VaiTro, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.VaiTro == VaiTro);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByMucAnLST(string MucAn)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.MucAn == MucAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByMucAnLST_Paged(string MucAn, int PageNumber, int PageSize)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.MucAn == MucAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMucAnRDT(string MucAn)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.MucAn == MucAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMucAnRDT_Paged(string MucAn, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.MucAn == MucAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByIdLoaiTienAnLST(Guid IdLoaiTienAn)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdLoaiTienAn == IdLoaiTienAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByIdLoaiTienAnLST_Paged(Guid IdLoaiTienAn, int PageNumber, int PageSize)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdLoaiTienAn == IdLoaiTienAn);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdLoaiTienAnRDT(Guid IdLoaiTienAn)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdLoaiTienAn == IdLoaiTienAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdLoaiTienAnRDT_Paged(Guid IdLoaiTienAn, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdLoaiTienAn == IdLoaiTienAn);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByTongHopLST(string TongHop)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.TongHop == TongHop);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByTongHopLST_Paged(string TongHop, int PageNumber, int PageSize)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.TongHop == TongHop);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTongHopRDT(string TongHop)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.TongHop == TongHop);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTongHopRDT_Paged(string TongHop, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.TongHop == TongHop);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return EntityCollection<TienAnDoiTuongEntity>
		public EntityCollection<TienAnDoiTuongEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<TienAnDoiTuongEntity> _TienAnDoiTuongCollection = new EntityCollection<TienAnDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_TienAnDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _TienAnDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _TienAnDoiTuongCollection = new EntityCollection(new TienAnDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(TienAnDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_TienAnDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
